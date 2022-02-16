using Home.Core.Models;

namespace Home.Core.Modules
{
    public class DistanceSensor : ModuleBase
    {
        public DistanceSensor(string pin) : base(pin)
        {
            ModuleType = EModule.DistanceSensor;
            Name = "DistanceSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}