using Home.Core.Models;

namespace Home.Core.Modules;

public class ModuleBase
{
    public EModule ModuleType;
    public string Name;
    public string Pin;
    public EConnectionType ConnectionType;

    public Type ValueType { get; set; }
    public int ValueMinInt { get; set; }
    public int ValueMaxInt { get; set; }
    public string Value { get; set; }
    
    public ModuleBase(string pin)
    {
        Pin = pin;
    }
}