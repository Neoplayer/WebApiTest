using Home.Core.Models;

namespace Home.Core.Modules
{
    public class MagneticFieldSensor : ModuleBase
    {
        public MagneticFieldSensor(string pin) : base(pin)
        {
            ModuleType = EModule.MagneticFieldSensor;
            Name = "MagneticFieldSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}