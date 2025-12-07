namespace VMixHTTP;

using System.Net;
using VMixHTTP.Exceptions;

/// <summary>
/// Represents a client for interacting with the vMix HTTP API.
/// </summary>
public partial class vMixClient
{
    private readonly HttpClient _client;
    private readonly string _baseUrl;

    /// <summary>
    /// Initializes a new instance of the <see cref="vMixClient"/> class.
    /// </summary>
    /// <param name="client">The HTTP Client to be used</param>
    /// <param name="baseUrl">The base URL of the vMix instance.</param>
    public vMixClient(HttpClient client, string baseUrl)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
        _baseUrl = baseUrl?.TrimEnd('/') ?? throw new ArgumentNullException(nameof(baseUrl));
    }

    /// <summary>
    /// Gets the version of the wrapper.
    /// </summary>
    /// <returns>The wrapper version.</returns>
    public string GetWrapperVersion()
    {
        return "0.0.1";
    }

    /// <summary>
    /// Gets the details of the vMix instance asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the vMix object.</returns>
    public async Task<vMix> GetvMixAsync()
    {
        var response = await SendRequestAsync("");
        return vMixXMLParser.Parse(response);
    }

    /// <summary>
    /// Sends a request to the vMix API asynchronously.
    /// </summary>
    /// <param name="request">The request string to be sent to the API.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    private async Task<string> SendRequestAsync(string request)
    {
        var url = string.IsNullOrEmpty(request) 
            ? $"{_baseUrl}/api/" 
            : $"{_baseUrl}/api/?{request}";
        
        try
        {
            var response = await _client.GetAsync(url);
            
            if (!response.IsSuccessStatusCode)
            {
                var statusCode = (int)response.StatusCode;
                var errorMessage = response.StatusCode == HttpStatusCode.NotFound
                    ? $"vMix API endpoint not found. Ensure vMix is running at {_baseUrl}"
                    : $"vMix API request failed with status code {statusCode}: {response.ReasonPhrase}";
                
                throw new vMixApiException(errorMessage, url, statusCode);
            }
            
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            throw new vMixApiException($"Failed to connect to vMix API at {url}. Ensure vMix is running and accessible.", url, innerException: ex);
        }
        catch (TaskCanceledException ex)
        {
            throw new vMixApiException($"Request to vMix API timed out: {url}", url, innerException: ex);
        }
        catch (vMixApiException)
        {
            // Re-throw vMixApiException as-is
            throw;
        }
        catch (Exception ex)
        {
            throw new vMixApiException($"Unexpected error calling vMix API: {ex.Message}", url, innerException: ex);
        }
    }

    /// <summary>
    /// Executes a command string and returns the API response.
    /// </summary>
    /// <param name="commandString">The command query string.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    private Task<string> ExecuteCommandAsync(string commandString) 
        => SendRequestAsync(commandString);

    /// <summary>
    /// Sends a command to the vMix API using the calling method's name as the function name.
    /// </summary>
    /// <param name="parameters">Optional anonymous object containing command parameters (Input, Value, etc.).</param>
    /// <param name="functionName">The function name, automatically captured from the calling method.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response.</returns>
    private Task<string> SendAsync(object? parameters = null, [System.Runtime.CompilerServices.CallerMemberName] string functionName = "")
    {
        var queryString = BuildQueryString(functionName, parameters);
        return ExecuteCommandAsync(queryString);
    }

    /// <summary>
    /// Builds a query string from the function name and parameters object.
    /// </summary>
    /// <param name="functionName">The vMix function name.</param>
    /// <param name="parameters">An anonymous object containing the parameters.</param>
    /// <returns>The formatted query string.</returns>
    private static string BuildQueryString(string functionName, object? parameters)
    {
        var parts = new List<string> { $"Function={functionName}" };
        
        if (parameters != null)
        {
            foreach (var prop in parameters.GetType().GetProperties())
            {
                var value = prop.GetValue(parameters);
                if (value != null)
                {
                    var stringValue = value is double d 
                        ? d.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)
                        : value.ToString();
                    parts.Add($"{prop.Name}={Uri.EscapeDataString(stringValue!)}");
                }
            }
        }
        
        return string.Join("&", parts);
    }
}