using System.Xml.Linq;

namespace VMixHTTP;

public static class vMixXMLParser
{
    
    /// <summary>
    /// Parses the specified XML string into a <see cref="vMix"/> object.
    /// </summary>
    /// <param name="xml">The XML document returned by the vMix web api</param>
    /// <returns>An instance of a vMix object</returns>
    public static vMix Parse(string xml)
    {
        var doc = XDocument.Parse(xml);
        
        if (doc.Root is null)
        {
            throw new FormatException("Invalid XML document");
        }
        
        var vmix = new vMix
        {
            Version = doc.Root.Element("version")?.Value,
            Edition = doc.Root.Element("edition")?.Value,
            Active = int.Parse(doc.Root.Element("active")?.Value ?? "0"),
            Preview = int.Parse(doc.Root.Element("preview")?.Value ?? "0"),
            FadeToBlack = bool.Parse(doc.Root.Element("fadeToBlack")?.Value ?? "false"),
            Recording = bool.Parse(doc.Root.Element("recording")?.Value ?? "false"),
            External = bool.Parse(doc.Root.Element("external")?.Value ?? "false"),
            Streaming = bool.Parse(doc.Root.Element("streaming")?.Value ?? "false"),
            PlayList = bool.Parse(doc.Root.Element("playList")?.Value ?? "false"),
            MultiCorder = bool.Parse(doc.Root.Element("multiCorder")?.Value ?? "false"),
            Fullscreen = bool.Parse(doc.Root.Element("fullscreen")?.Value ?? "false"),
            Inputs = doc.Root.Element("inputs")?.Elements("input").Select(e => new vMixInput
            {
                Key = e.Attribute("key")?.Value,
                Number = int.Parse(e.Attribute("number")?.Value ?? "0"),
                Title = e.Attribute("title")?.Value,
                ShortTitle = e.Attribute("shortTitle")?.Value,
                Type = e.Attribute("type")?.Value,
                State = e.Attribute("state")?.Value,
                Position = e.Attribute("position")?.Value,
                Duration = e.Attribute("duration")?.Value,
                Loop = e.Attribute("loop")?.Value,
                Muted = bool.Parse(e.Attribute("muted")?.Value ?? "false")
            }).ToList(),
            Overlays = doc.Root.Element("overlays")?.Elements("overlay").Select(e => new vMixOverlay
            {
                Number = int.Parse(e.Attribute("number")?.Value ?? "0")
            }).ToList(),
            Transitions = doc.Root.Element("transitions")?.Elements("transition").Select(e => new vMixTransition
            {
                Number = int.Parse(e.Attribute("number")?.Value ?? "0"),
                Effect = e.Attribute("effect")?.Value,
                Duration = e.Attribute("duration")?.Value
            }).ToList(),
            Audio = doc.Root.Element("audio")?.Elements().Select(e => new vMixAudio
            {
                Name = e.Name.LocalName,
                Volume = double.Parse(e.Attribute("volume")?.Value ?? "0"),
                Muted = bool.Parse(e.Attribute("muted")?.Value ?? "false"),
                meterF1 = double.Parse(e.Attribute("meterF1")?.Value ?? "0"),
                meterF2 = double.Parse(e.Attribute("meterF2")?.Value ?? "0"),
                HeadphonesVolume = double.Parse(e.Attribute("headphonesVolume")?.Value ?? "0")
            }).ToList()
        };

        return vmix;
    }
}