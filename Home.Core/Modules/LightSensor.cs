using Home.Core.Models;

namespace Home.Core.Modules
{
    public class LightSensor : ModuleBase
    {
        public LightSensor(string pin) : base(pin)
        {
            ModuleType = EModule.LightSensor;
            Name = "LightSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}