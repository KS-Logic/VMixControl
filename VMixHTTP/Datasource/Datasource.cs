namespace VMixHTTP;

/// <summary>
/// Partial class containing datasource-related vMix API commands.
/// </summary>
public partial class vMixClient
{
    #region DataSource Controls
    
    /// <summary>Disables auto-next for the datasource table.</summary>
    public Task<string> DataSourceAutoNextOff(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Enables auto-next for the datasource table.</summary>
    public Task<string> DataSourceAutoNextOn(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Toggles auto-next for the datasource table.</summary>
    public Task<string> DataSourceAutoNextOnOff(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Moves to the next row in the datasource table.</summary>
    public Task<string> DataSourceNextRow(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Pauses the datasource table.</summary>
    public Task<string> DataSourcePause(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Plays the datasource table.</summary>
    public Task<string> DataSourcePlay(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Toggles play/pause for the datasource table.</summary>
    public Task<string> DataSourcePlayPause(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Moves to the previous row in the datasource table.</summary>
    public Task<string> DataSourcePreviousRow(string datasourceName, string table) 
        => SendAsync(new { Value = $"{datasourceName},{table}" });
    
    /// <summary>Selects a specific row in the datasource table.</summary>
    public Task<string> DataSourceSelectRow(string datasourceName, string table, int index) 
        => SendAsync(new { Value = $"{datasourceName},{table},{index}" });
    
    /// <summary>Selects a specific row in the datasource table with row number.</summary>
    public Task<string> DataSourceSelectRow(string datasourceName, string table, int index, int rowNumber) 
        => SendAsync(new { Value = $"{datasourceName},{table},{index},{rowNumber}" });
    
    /// <summary>Selects a specific row in the datasource table with row number and n.</summary>
    public Task<string> DataSourceSelectRow(string datasourceName, string table, int index, int rowNumber, int n) 
        => SendAsync(new { Value = $"{datasourceName},{table},{index},{rowNumber},{n}" });
    
    #endregion
}