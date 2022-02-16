using Home.Core.Models;

namespace Home.Core.Modules
{
    public class PositionSensor : ModuleBase
    {
        public PositionSensor(string pin) : base(pin)
        {
            ModuleType = EModule.PositionSensor;
            Name = "PositionSensor";
            ConnectionType = EConnectionType.I2C;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}