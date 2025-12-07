namespace VMixHTTP.Exceptions;

/// <summary>
/// Exception thrown when a vMix API call fails.
/// </summary>
public class vMixApiException : Exception
{
    /// <summary>
    /// Gets the HTTP status code if available.
    /// </summary>
    public int? StatusCode { get; }

    /// <summary>
    /// Gets the request URL that failed.
    /// </summary>
    public string? RequestUrl { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="vMixApiException"/> class.
    /// </summary>
    /// <param name="message">The error message.</param>
    public vMixApiException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="vMixApiException"/> class.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="innerException">The inner exception.</param>
    public vMixApiException(string message, Exception innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="vMixApiException"/> class.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="requestUrl">The request URL that failed.</param>
    /// <param name="statusCode">The HTTP status code.</param>
    /// <param name="innerException">The inner exception.</param>
    public vMixApiException(string message, string requestUrl, int? statusCode = null, Exception? innerException = null) 
        : base(message, innerException)
    {
        RequestUrl = requestUrl;
        StatusCode = statusCode;
    }
}

