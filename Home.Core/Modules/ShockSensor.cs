using Home.Core.Models;

namespace Home.Core.Modules
{
    public class ShockSensor : ModuleBase
    {
        public ShockSensor(string pin) : base(pin)
        {
            ModuleType = EModule.ShockSensor;
            Name = "ShockSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}