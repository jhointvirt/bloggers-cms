namespace Pds.Api.Contracts.Settings;

public class SettingDto
{
    public Guid Id { get; set; }
    public string Key { get; set; }
    
    public string Value { get; set; }
    
    public string Description { get; set; }
}