namespace VMixHTTP;

public class vMix
{
    public string? Version { get; set; }
    public string? Edition { get; set; }
    public string? PresetPath { get; set; }
    
    public int Active { get; set; }

    public vMixInput ActiveInput
    {
        get
        {
            return Inputs.FirstOrDefault(i => i.Number == Active);
        }
    }
    
    public int Preview { get; set; }
    
    public vMixInput? PreviewInput
    {
        get
        {
            return Inputs.FirstOrDefault(i => i.Number == Preview);
        }
    }
    
    public List<vMixInput>? Inputs { get; set; }
    public List<vMixOverlay>? Overlays { get; set; }
    public List<vMixTransition>? Transitions { get; set; }
    
    public bool FadeToBlack { get; set; }
    public bool Recording { get; set; }
    public bool External { get; set; }
    public bool Streaming { get; set; }
    public bool PlayList { get; set; }
    public bool MultiCorder { get; set; }
    public bool Fullscreen { get; set; }
    
    public List<vMixAudio>? Audio { get; set; }
    
    
}

public class vMixInput
{
    public string? Key { get; set; }
    public int? Number { get; set; }
    public string? Title { get; set; }
    public string? ShortTitle { get; set; }
    public string? Type { get; set; }
    public string? State { get; set; }
    public string? Position { get; set; }
    public string? Duration { get; set; }
    public string? Loop { get; set; }
    public bool? Muted { get; set; }
}

public class vMixOverlay
{
    public int? Number { get; set; }
}

public class vMixTransition
{
    public int? Number { get; set; }
    public string? Duration { get; set; }
    public string? Effect { get; set; }
}

public class vMixAudio
{
    public string Name { get; set; }
    public double Volume { get; set; }
    public bool Muted { get; set; }
    public double meterF1 { get; set; }
    public double meterF2 { get; set; }
    public double HeadphonesVolume { get; set; }
}