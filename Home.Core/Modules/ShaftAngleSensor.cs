using Home.Core.Models;

namespace Home.Core.Modules
{
    public class ShaftAngleSensor : ModuleBase
    {
        public ShaftAngleSensor(string pin) : base(pin)
        {
            ModuleType = EModule.ShaftAngleSensor;
            Name = "ShaftAngleSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}