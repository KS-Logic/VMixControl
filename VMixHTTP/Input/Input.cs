namespace VMixHTTP;

/// <summary>
/// Partial class containing input-related vMix API commands.
/// </summary>
public partial class vMixClient
{
    /// <summary>
    /// Send specified input to Output (Mix 0). Specify mix number if not targeting mix 0.
    /// </summary>
    public Task<string> ActiveInput(string input, int mix = 0) => SendAsync(new { Input = input, Mix = mix });

    ///  <summary>
    ///  Create a new input.
    ///  </summary>
    ///  <returns></returns>
    ///  <param name="value">Format "type|filename" - 
    ///      Samples:
    ///      Video|c:\path\to\video.avi, 
    ///      Image|c:\path\to\image.jpg, 
    ///      Photos|c:\path\to\folder, 
    ///      Xaml|c:\path\to\title.xaml, 
    ///      VideoList|c:\path\to\playlist.m3u, 
    ///      Colour|HTMLColor, 
    ///      AudioFile|c:\path\to\audio.wav, 
    ///      Flash|c:\path\to\flash.swf, 
    ///      PowerPoint|c:\path\to\powerpoint.pptx, 
    ///      Value = Type|Filename
    ///  </param>
    public Task<string> AddInput(string value) => SendAsync(new { Value = value });
    
    public Task<string> AutoPauseOff(string input) => SendAsync(new { Input = input });
    
    public Task<string> AutoPauseOn(string input) => SendAsync(new { Input = input });
    
    /// <summary>
    /// Toggle automatically playing first item in a List with Transition.
    /// </summary>
    public Task<string> AutoPlayFirst(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn Off automatically playing first item in a List with Transition.
    /// </summary>
    public Task<string> AutoPlayFirstOff(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn On automatically playing first item in a List with Transition.
    /// </summary>
    public Task<string> AutoPlayFirstOn(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Toggle automatically playing next item in a List.
    /// </summary>
    public Task<string> AutoPlayNext(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn Off automatically playing next item in a List.
    /// </summary>
    public Task<string> AutoPlayNextOff(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn On automatically playing next item in a List.
    /// </summary>
    public Task<string> AutoPlayNextOn(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn Off AutoPlay for the specified input.
    /// </summary>
    public Task<string> AutoPlayOff(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn On AutoPlay for the specified input.
    /// </summary>
    public Task<string> AutoPlayOn(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn Off automatic restart for the specified input.
    /// </summary>
    public Task<string> AutoRestartOff(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn On automatic restart for the specified input.
    /// </summary>
    public Task<string> AutoRestartOn(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Create a new Virtual Input from the specified Input.
    /// </summary>
    public Task<string> CreateVirtualInput(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn Off deinterlacing for the specified input.
    /// </summary>
    public Task<string> DeinterlaceOff(string input) => SendAsync(new { Input = input });

    /// <summary>
    /// Turn On deinterlacing for the specified input.
    /// </summary>
    public Task<string> DeinterlaceOn(string input) => SendAsync(new { Input = input });

}