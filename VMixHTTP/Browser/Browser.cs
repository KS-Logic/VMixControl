namespace VMixHTTP;

/// <summary>
/// Partial class containing browser-related vMix API commands.
/// </summary>
public partial class vMixClient
{
    #region Browser Controls
    
    /// <summary>Navigates the browser input back.</summary>
    public Task<string> BrowserBack(string input) => SendAsync(new { Input = input });
    
    /// <summary>Navigates the browser input forward.</summary>
    public Task<string> BrowserForward(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables keyboard input for the browser.</summary>
    public Task<string> BrowserKeyboardDisabled(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables keyboard input for the browser.</summary>
    public Task<string> BrowserKeyboardEnabled(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables mouse input for the browser.</summary>
    public Task<string> BrowserMouseDisabled(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables mouse input for the browser.</summary>
    public Task<string> BrowserMouseEnabled(string input) => SendAsync(new { Input = input });
    
    /// <summary>Navigates the browser to the specified URL.</summary>
    public Task<string> BrowserNavigate(string input, string url) => SendAsync(new { Input = input, Value = url });
    
    /// <summary>Reloads the browser input.</summary>
    public Task<string> BrowserReload(string input) => SendAsync(new { Input = input });
    
    #endregion
}