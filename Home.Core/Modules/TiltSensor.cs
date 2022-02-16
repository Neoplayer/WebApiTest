using Home.Core.Models;

namespace Home.Core.Modules
{
    public class TiltSensor : ModuleBase
    {
        public TiltSensor(string pin) : base(pin)
        {
            ModuleType = EModule.TiltSensor;
            Name = "TiltSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}