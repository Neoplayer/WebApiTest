using Home.Core.Models;

namespace Home.Core.Modules;

public class ModuleBase
{
    public EModule ModuleType;
    public string Name;
    public string Pin;

    public string Value { get; set; }
    
    public ModuleBase(string pin)
    {
        Pin = pin;
    }
}