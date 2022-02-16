using Home.Core.Models;

namespace Home.Core.Modules
{
    public class TemperatureSensor : ModuleBase
    {
        public TemperatureSensor(string pin) : base(pin)
        {
            ModuleType = EModule.TemperatureSensor;
            Name = "TemperatureSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}