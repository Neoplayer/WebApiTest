using Home.Core.Modules;

namespace Home.Core.Dto;

public class UpdateModuleData
{
    public string user { get; set; }
    public string password { get; set; }
    public Command Command { get; set; }
}