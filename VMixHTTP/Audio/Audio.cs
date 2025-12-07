namespace VMixHTTP;

/// <summary>
/// Partial class containing audio-related vMix API commands.
/// </summary>
public partial class vMixClient
{
    #region Audio Basic Controls
    
    /// <summary>Toggles audio mute/unmute for the specified input. Note: vMix API function is "Audio".</summary>
    public Task<string> AudioMuteUnmute(string input) => SendAsync(new { Input = input }, "Audio");
    
    /// <summary>Toggles audio auto mode for the specified input.</summary>
    public Task<string> AudioAuto(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables audio auto mode for the specified input.</summary>
    public Task<string> AudioAutoOff(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables audio auto mode for the specified input.</summary>
    public Task<string> AudioAutoOn(string input) => SendAsync(new { Input = input });
    
    /// <summary>Toggles audio bus assignment for the specified input.</summary>
    public Task<string> AudioBus(string input, string bus) => SendAsync(new { Input = input, Value = bus });
    
    /// <summary>Removes audio bus assignment for the specified input.</summary>
    public Task<string> AudioBusOff(string input, string bus) => SendAsync(new { Input = input, Value = bus });
    
    /// <summary>Assigns audio bus for the specified input.</summary>
    public Task<string> AudioBusOn(string input, string bus) => SendAsync(new { Input = input, Value = bus });
    
    /// <summary>Applies a matrix preset to the audio channel.</summary>
    public Task<string> AudioChannelApplyMatrixPreset(string input, string preset) => SendAsync(new { Input = input, Value = preset });
    
    /// <summary>Shows or hides the audio mixer.</summary>
    public Task<string> AudioMixerShowHide() => SendAsync();
    
    /// <summary>Disables audio for the specified input.</summary>
    public Task<string> AudioOff(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables audio for the specified input.</summary>
    public Task<string> AudioOn(string input) => SendAsync(new { Input = input });
    
    #endregion

    #region Audio Plugins
    
    /// <summary>Enables audio plugin for the specified input.</summary>
    public Task<string> AudioPluginOn(string input, int pluginNumber) => SendAsync(new { Input = input, Value = pluginNumber });
    
    /// <summary>Disables audio plugin for the specified input.</summary>
    public Task<string> AudioPluginOff(string input, int pluginNumber) => SendAsync(new { Input = input, Value = pluginNumber });
    
    /// <summary>Toggles audio plugin for the specified input.</summary>
    public Task<string> AudioPluginOnOff(string input, int pluginNumber) => SendAsync(new { Input = input, Value = pluginNumber });
    
    /// <summary>Shows audio plugin UI for the specified input.</summary>
    public Task<string> AudioPluginShow(string input, int pluginNumber) => SendAsync(new { Input = input, Value = pluginNumber });
    
    #endregion

    #region Bus A Audio
    
    /// <summary>Toggles Bus A audio.</summary>
    public Task<string> BusAAudio() => SendAsync();
    
    /// <summary>Disables Bus A audio.</summary>
    public Task<string> BusAAudioOff() => SendAsync();
    
    /// <summary>Enables Bus A audio.</summary>
    public Task<string> BusAAudioOn() => SendAsync();
    
    /// <summary>Disables Bus A audio plugin.</summary>
    public Task<string> BusAAudioPluginOff(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Enables Bus A audio plugin.</summary>
    public Task<string> BusAAudioPluginOn(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Toggles Bus A audio plugin.</summary>
    public Task<string> BusAAudioPluginOnOff(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Shows Bus A audio plugin UI.</summary>
    public Task<string> BusAAudioPluginShow(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    #endregion

    #region Bus B Audio
    
    /// <summary>Toggles Bus B audio.</summary>
    public Task<string> BusBAudio() => SendAsync();
    
    /// <summary>Disables Bus B audio.</summary>
    public Task<string> BusBAudioOff() => SendAsync();
    
    /// <summary>Enables Bus B audio.</summary>
    public Task<string> BusBAudioOn() => SendAsync();
    
    /// <summary>Disables Bus B audio plugin.</summary>
    public Task<string> BusBAudioPluginOff(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Enables Bus B audio plugin.</summary>
    public Task<string> BusBAudioPluginOn(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Toggles Bus B audio plugin.</summary>
    public Task<string> BusBAudioPluginOnOff(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Shows Bus B audio plugin UI.</summary>
    public Task<string> BusBAudioPluginShow(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    #endregion

    #region Bus X Audio (Generic Bus)
    
    /// <summary>Toggles Bus X audio.</summary>
    public Task<string> BusXAudio(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Disables Bus X audio.</summary>
    public Task<string> BusXAudioOff(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Enables Bus X audio.</summary>
    public Task<string> BusXAudioOn(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Disables Bus X audio plugin.</summary>
    public Task<string> BusXAudioPluginOff(string bus, int pluginNumber) => SendAsync(new { Value = $"{bus},{pluginNumber}" });
    
    /// <summary>Enables Bus X audio plugin.</summary>
    public Task<string> BusXAudioPluginOn(string bus, int pluginNumber) => SendAsync(new { Value = $"{bus},{pluginNumber}" });
    
    /// <summary>Toggles Bus X audio plugin.</summary>
    public Task<string> BusXAudioPluginOnOff(string bus, int pluginNumber) => SendAsync(new { Value = $"{bus},{pluginNumber}" });
    
    /// <summary>Shows Bus X audio plugin UI.</summary>
    public Task<string> BusXAudioPluginShow(string bus, int pluginNumber) => SendAsync(new { Value = $"{bus},{pluginNumber}" });
    
    /// <summary>Toggles Bus X send to master.</summary>
    public Task<string> BusXSendToMaster(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Enables Bus X send to master.</summary>
    public Task<string> BusXSendToMasterOn(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Disables Bus X send to master.</summary>
    public Task<string> BusXSendToMasterOff(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Toggles Bus X solo.</summary>
    public Task<string> BusXSolo(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Enables Bus X solo.</summary>
    public Task<string> BusXSoloOn(string bus) => SendAsync(new { Value = bus });
    
    /// <summary>Disables Bus X solo.</summary>
    public Task<string> BusXSoloOff(string bus) => SendAsync(new { Value = bus });
    
    #endregion

    #region Master Audio
    
    /// <summary>Toggles master audio.</summary>
    public Task<string> MasterAudio() => SendAsync();
    
    /// <summary>Disables master audio.</summary>
    public Task<string> MasterAudioOff() => SendAsync();
    
    /// <summary>Enables master audio.</summary>
    public Task<string> MasterAudioOn() => SendAsync();
    
    /// <summary>Disables master audio plugin.</summary>
    public Task<string> MasterAudioPluginOff(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Enables master audio plugin.</summary>
    public Task<string> MasterAudioPluginOn(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Toggles master audio plugin.</summary>
    public Task<string> MasterAudioPluginOnOff(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    /// <summary>Shows master audio plugin UI.</summary>
    public Task<string> MasterAudioPluginShow(int pluginNumber) => SendAsync(new { Value = pluginNumber });
    
    #endregion

    #region Set Balance and Gain
    
    /// <summary>Sets the balance for the specified input (-1 to 1).</summary>
    public Task<string> SetBalance(string input, double balance) => SendAsync(new { Input = input, Value = Math.Clamp(balance, -1, 1) });
    
    /// <summary>Sets the gain for the specified input (0 to 24 dB).</summary>
    public Task<string> SetGain(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 24) });
    
    /// <summary>Sets the gain for channel 1 of the specified input (0 to 24 dB).</summary>
    public Task<string> SetGainChannel1(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 24) });
    
    /// <summary>Sets the gain for channel 2 of the specified input (0 to 24 dB).</summary>
    public Task<string> SetGainChannel2(string input, double gain) => SendAsync(new { Input = input, Value = Math.Clamp(gain, 0, 24) });
    
    #endregion

    #region Set Bus Volume
    
    /// <summary>Sets Bus A volume (0-100).</summary>
    public Task<string> SetBusAVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus B volume (0-100).</summary>
    public Task<string> SetBusBVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus C volume (0-100).</summary>
    public Task<string> SetBusCVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus D volume (0-100).</summary>
    public Task<string> SetBusDVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus E volume (0-100).</summary>
    public Task<string> SetBusEVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus F volume (0-100).</summary>
    public Task<string> SetBusFVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus G volume (0-100).</summary>
    public Task<string> SetBusGVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets headphones volume (0-100).</summary>
    public Task<string> SetHeadphonesVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets master volume (0-100).</summary>
    public Task<string> SetMasterVolume(int volume) => SendAsync(new { Value = Math.Clamp(volume, 0, 100) });
    
    #endregion

    #region Set Input Volume
    
    /// <summary>Sets volume for the specified input (0-100).</summary>
    public Task<string> SetVolume(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets bus mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixer(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus A mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerA(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus B mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerB(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus C mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerC(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus D mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerD(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus E mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerE(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus F mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerF(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus G mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerG(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets Bus M (Master) mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeBusMixerM(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel 1 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannel1(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel 2 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannel2(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    #endregion

    #region Set Volume Channel Mixer 1-16
    
    /// <summary>Sets channel mixer 1 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer1(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 2 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer2(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 3 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer3(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 4 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer4(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 5 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer5(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 6 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer6(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 7 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer7(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 8 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer8(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 9 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer9(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 10 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer10(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 11 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer11(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 12 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer12(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 13 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer13(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 14 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer14(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 15 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer15(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    /// <summary>Sets channel mixer 16 volume for the specified input (0-100).</summary>
    public Task<string> SetVolumeChannelMixer16(string input, int volume) => SendAsync(new { Input = input, Value = Math.Clamp(volume, 0, 100) });
    
    #endregion

    #region Volume Fade and Solo
    
    /// <summary>Fades volume for the specified input to target level over duration.</summary>
    public Task<string> SetVolumeFade(string input, int volume, int duration) => SendAsync(new { Input = input, Value = $"{Math.Clamp(volume, 0, 100)},{duration}" });
    
    /// <summary>Toggles solo for the specified input.</summary>
    public Task<string> Solo(string input) => SendAsync(new { Input = input });
    
    /// <summary>Disables all solo.</summary>
    public Task<string> SoloAllOff() => SendAsync();
    
    /// <summary>Disables solo for the specified input.</summary>
    public Task<string> SoloOff(string input) => SendAsync(new { Input = input });
    
    /// <summary>Enables solo for the specified input.</summary>
    public Task<string> SoloOn(string input) => SendAsync(new { Input = input });
    
    /// <summary>Toggles solo PFL (Pre-Fader Listen).</summary>
    public Task<string> SoloPFL() => SendAsync();
    
    /// <summary>Disables solo PFL.</summary>
    public Task<string> SoloPFLOff() => SendAsync();
    
    /// <summary>Enables solo PFL.</summary>
    public Task<string> SoloPFLOn() => SendAsync();
    
    #endregion
}