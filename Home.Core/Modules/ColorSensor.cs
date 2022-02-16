using Home.Core.Models;

namespace Home.Core.Modules
{
    public class ColorSensor : ModuleBase
    {
        public ColorSensor(string pin) : base(pin)
        {
            ModuleType = EModule.ColorSensor;
            Name = "ColorSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}