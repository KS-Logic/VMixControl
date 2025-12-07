using VMixHTTP;
using VMixHTTP.Exceptions;

// Best practice: Reuse HttpClient instance
var httpClient = new HttpClient 
{ 
    Timeout = TimeSpan.FromSeconds(10) 
};

var client = new vMixClient(httpClient, "http://localhost:8088");

try
{
    // Get vMix state
    vMix vmix = await client.GetvMixAsync();
    Console.WriteLine($"vMix version: {vmix.Version}");
    Console.WriteLine($"vMix edition: {vmix.Edition}");
    Console.WriteLine($"Active inputs: {vmix.Inputs?.Count ?? 0}");
    
    // Find input by title
    string input = "scr browser";
    vMixInput? inputInfo = vmix.Inputs?.FirstOrDefault(i => i.Title == input);
    
    if (inputInfo != null)
    {
        Console.WriteLine($"\nInput: {input}");
        Console.WriteLine($"  Type: {inputInfo.Type}");
        Console.WriteLine($"  State: {inputInfo.State}");
        Console.WriteLine($"  Audio muted: {inputInfo.Muted}");

        // Toggle audio
        Console.WriteLine($"\nToggling audio for '{input}'...");
        string response = await client.AudioMuteUnmute(input);
        Console.WriteLine($"Response: {response}");

        // Verify the change
        vmix = await client.GetvMixAsync();
        inputInfo = vmix.Inputs?.FirstOrDefault(i => i.Title == input);
        Console.WriteLine($"Audio muted now: {inputInfo?.Muted}");
    }
    else
    {
        Console.WriteLine($"Input '{input}' not found");
        Console.WriteLine("\nAvailable inputs:");
        foreach (var inp in vmix.Inputs ?? Enumerable.Empty<vMixInput>())
        {
            Console.WriteLine($"  - {inp.Title} (Type: {inp.Type})");
        }
    }
}
catch (vMixApiException ex)
{
    Console.WriteLine($"\n❌ vMix API Error: {ex.Message}");
    if (ex.StatusCode.HasValue)
        Console.WriteLine($"   Status Code: {ex.StatusCode}");
    if (ex.RequestUrl != null)
        Console.WriteLine($"   URL: {ex.RequestUrl}");
    if (ex.InnerException != null)
        Console.WriteLine($"   Inner: {ex.InnerException.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"\n❌ Unexpected error: {ex.Message}");
}
finally
{
    httpClient.Dispose();
}
