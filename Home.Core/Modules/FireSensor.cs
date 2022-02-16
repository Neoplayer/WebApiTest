using Home.Core.Models;

namespace Home.Core.Modules
{
    public class FireSensor : ModuleBase
    {
        public FireSensor(string pin) : base(pin)
        {
            ModuleType = EModule.FireSensor;
            Name = "FireSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}