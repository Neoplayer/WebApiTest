using Home.Core.Models;

namespace Home.Core.Modules
{
    public class Display : ModuleBase
    {
        public Display(string pin) : base(pin)
        {
            ModuleType = EModule.Display;
            Name = "Display";
            ConnectionType = EConnectionType.UART;
            ValueType = typeof(string);
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}