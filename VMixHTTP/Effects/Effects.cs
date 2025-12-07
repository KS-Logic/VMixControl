namespace VMixHTTP;

/// <summary>
/// Partial class containing effects-related vMix API commands.
/// </summary>
public partial class vMixClient
{
    #region Effect 1
    
    /// <summary>Toggles effect 1 for the specified input.</summary>
    public Task<string> Effect1(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables effect 1 for the specified input.</summary>
    public Task<string> Effect1Off(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables effect 1 for the specified input.</summary>
    public Task<string> Effect1On(string input) => SendAsync(new { Input = input });
    
    /// <summary>Sets effect 1 strength for the specified input (0-1).</summary>
    public Task<string> SetEffect1Strength(string input, double strength) => SendAsync(new { Input = input, Value = Math.Clamp(strength, 0, 1) });
    
    #endregion

    #region Effect 2
    
    /// <summary>Toggles effect 2 for the specified input.</summary>
    public Task<string> Effect2(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables effect 2 for the specified input.</summary>
    public Task<string> Effect2Off(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables effect 2 for the specified input.</summary>
    public Task<string> Effect2On(string input) => SendAsync(new { Input = input });
    
    /// <summary>Sets effect 2 strength for the specified input (0-1).</summary>
    public Task<string> SetEffect2Strength(string input, double strength) => SendAsync(new { Input = input, Value = Math.Clamp(strength, 0, 1) });
    
    #endregion

    #region Effect 3
    
    /// <summary>Toggles effect 3 for the specified input.</summary>
    public Task<string> Effect3(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables effect 3 for the specified input.</summary>
    public Task<string> Effect3Off(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables effect 3 for the specified input.</summary>
    public Task<string> Effect3On(string input) => SendAsync(new { Input = input });
    
    /// <summary>Sets effect 3 strength for the specified input (0-1).</summary>
    public Task<string> SetEffect3Strength(string input, double strength) => SendAsync(new { Input = input, Value = Math.Clamp(strength, 0, 1) });
    
    #endregion

    #region Effect 4
    
    /// <summary>Toggles effect 4 for the specified input.</summary>
    public Task<string> Effect4(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables effect 4 for the specified input.</summary>
    public Task<string> Effect4Off(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables effect 4 for the specified input.</summary>
    public Task<string> Effect4On(string input) => SendAsync(new { Input = input });
    
    /// <summary>Sets effect 4 strength for the specified input (0-1).</summary>
    public Task<string> SetEffect4Strength(string input, double strength) => SendAsync(new { Input = input, Value = Math.Clamp(strength, 0, 1) });
    
    #endregion

    #region Frame Delay
    
    /// <summary>Sets the frame delay for the specified input.</summary>
    public Task<string> SetFrameDelay(string input, double delay) => SendAsync(new { Input = input, Value = delay });
    
    #endregion
}