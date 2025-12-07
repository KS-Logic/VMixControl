namespace VMixHTTP;

/// <summary>
/// Partial class containing dynamic variables vMix API commands.
/// </summary>
public partial class vMixClient
{
    #region Dynamic Inputs
    
    /// <summary>Sets dynamic input 1.</summary>
    public Task<string> SetDynamicInput1(string input) => SendAsync(new { Value = input });
    
    /// <summary>Sets dynamic input 2.</summary>
    public Task<string> SetDynamicInput2(string input) => SendAsync(new { Value = input });
    
    /// <summary>Sets dynamic input 3.</summary>
    public Task<string> SetDynamicInput3(string input) => SendAsync(new { Value = input });
    
    /// <summary>Sets dynamic input 4.</summary>
    public Task<string> SetDynamicInput4(string input) => SendAsync(new { Value = input });
    
    #endregion

    #region Dynamic Values
    
    /// <summary>Sets dynamic value 1.</summary>
    public Task<string> SetDynamicValue1(string value) => SendAsync(new { Value = value });
    
    /// <summary>Sets dynamic value 2.</summary>
    public Task<string> SetDynamicValue2(string value) => SendAsync(new { Value = value });
    
    /// <summary>Sets dynamic value 3.</summary>
    public Task<string> SetDynamicValue3(string value) => SendAsync(new { Value = value });
    
    /// <summary>Sets dynamic value 4.</summary>
    public Task<string> SetDynamicValue4(string value) => SendAsync(new { Value = value });
    
    #endregion
}