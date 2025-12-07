namespace VMixHTTP;

/// <summary>
/// Partial class containing colour correction vMix API commands.
/// </summary>
public partial class vMixClient
{
    #region Colour Correction Auto/Reset
    
    /// <summary>Auto colour correction for the specified input.</summary>
    public Task<string> ColourCorrectionAuto(string input) => SendAsync(new { Input = input });
    
    /// <summary>Resets colour correction for the specified input.</summary>
    public Task<string> ColourCorrectionReset(string input) => SendAsync(new { Input = input });
    
    #endregion

    #region Alpha
    
    /// <summary>Sets the alpha value for the specified input (0-255).</summary>
    public Task<string> SetAlpha(string input, int alpha) => SendAsync(new { Input = input, Value = Math.Clamp(alpha, 0, 255) });
    
    #endregion

    #region CC Gain
    
    /// <summary>Sets the blue gain for colour correction (0-2). Note: vMix API function is "SetCCGainBlue".</summary>
    public Task<string> SetCCGainB(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 2) }, "SetCCGainBlue");
    
    /// <summary>Sets the green gain for colour correction (0-2). Note: vMix API function is "SetCCGainGreen".</summary>
    public Task<string> SetCCGainG(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 2) }, "SetCCGainGreen");
    
    /// <summary>Sets the red gain for colour correction (0-2). Note: vMix API function is "SetCCGainRed".</summary>
    public Task<string> SetCCGainR(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 2) }, "SetCCGainRed");
    
    /// <summary>Sets the RGB gain for colour correction (0-2).</summary>
    public Task<string> SetCCGainRGB(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 2) });
    
    /// <summary>Sets the yellow gain for colour correction (0-2). Note: vMix API function is "SetCCGainYellow".</summary>
    public Task<string> SetCCGainY(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 2) }, "SetCCGainYellow");
    
    #endregion

    #region CC Gamma
    
    /// <summary>Sets the blue gamma for colour correction (-1 to 1). Note: vMix API function is "SetCCGammaBlue".</summary>
    public Task<string> SetCCGammaB(string input, double gamma) => SendAsync(new { Input = input, Value = Math.Clamp(gamma, -1, 1) }, "SetCCGammaBlue");
    
    /// <summary>Sets the green gamma for colour correction (-1 to 1). Note: vMix API function is "SetCCGammaGreen".</summary>
    public Task<string> SetCCGammaG(string input, double gamma) => SendAsync(new { Input = input, Value = Math.Clamp(gamma, -1, 1) }, "SetCCGammaGreen");
    
    /// <summary>Sets the red gamma for colour correction (-1 to 1). Note: vMix API function is "SetCCGammaRed".</summary>
    public Task<string> SetCCGammaR(string input, double gamma) => SendAsync(new { Input = input, Value = Math.Clamp(gamma, -1, 1) }, "SetCCGammaRed");
    
    /// <summary>Sets the RGB gamma for colour correction (-1 to 1).</summary>
    public Task<string> SetCCGammaRGB(string input, double gamma) => SendAsync(new { Input = input, Value = Math.Clamp(gamma, -1, 1) });
    
    /// <summary>Sets the yellow gamma for colour correction (-1 to 1). Note: vMix API function is "SetCCGammaYellow".</summary>
    public Task<string> SetCCGammaY(string input, double gamma) => SendAsync(new { Input = input, Value = Math.Clamp(gamma, -1, 1) }, "SetCCGammaYellow");
    
    #endregion

    #region CC Hue and Saturation
    
    /// <summary>Sets the hue for colour correction (-1 to 1).</summary>
    public Task<string> SetCCHue(string input, double hue) => SendAsync(new { Input = input, Value = Math.Clamp(hue, -1, 1) });
    
    /// <summary>Sets the saturation for colour correction (-1 to 1).</summary>
    public Task<string> SetCCSaturation(string input, double saturation) => SendAsync(new { Input = input, Value = Math.Clamp(saturation, -1, 1) });
    
    #endregion

    #region CC Lift
    
    /// <summary>Sets the blue lift for colour correction (-1 to 1). Note: vMix API function is "SetCCLiftBlue".</summary>
    public Task<string> SetCCLiftB(string input, double lift) => SendAsync(new { Input = input, Value = Math.Clamp(lift, -1, 1) }, "SetCCLiftBlue");
    
    /// <summary>Sets the green lift for colour correction (-1 to 1). Note: vMix API function is "SetCCLiftGreen".</summary>
    public Task<string> SetCCLiftG(string input, double lift) => SendAsync(new { Input = input, Value = Math.Clamp(lift, -1, 1) }, "SetCCLiftGreen");
    
    /// <summary>Sets the red lift for colour correction (-1 to 1). Note: vMix API function is "SetCCLiftRed".</summary>
    public Task<string> SetCCLiftR(string input, double lift) => SendAsync(new { Input = input, Value = Math.Clamp(lift, -1, 1) }, "SetCCLiftRed");
    
    /// <summary>Sets the RGB lift for colour correction (-1 to 1).</summary>
    public Task<string> SetCCLiftRGB(string input, double lift) => SendAsync(new { Input = input, Value = Math.Clamp(lift, -1, 1) });
    
    /// <summary>Sets the yellow lift for colour correction (-1 to 1). Note: vMix API function is "SetCCLiftYellow".</summary>
    public Task<string> SetCCLiftY(string input, double lift) => SendAsync(new { Input = input, Value = Math.Clamp(lift, -1, 1) }, "SetCCLiftYellow");
    
    #endregion
}