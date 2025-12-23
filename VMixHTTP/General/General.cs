namespace VMixHTTP;

/// <summary>
/// Partial class containing general vMix API commands.
/// </summary>
public partial class vMixClient
{
    /// <summary>
    /// Refresh all activator device lights and controls.
    /// </summary>
    public Task<string> ActivatorRefresh() => SendAsync();
    
    /// <summary>
    /// Send single key press to active window.
    /// </summary>
    public Task<string> KeyPress(string key) => SendAsync(new { Value = key });
    
    /// <summary>
    /// Send keys to active window
    /// </summary>
    public Task<string> SendKeys(string keys) => SendAsync(new { Value = keys });
}