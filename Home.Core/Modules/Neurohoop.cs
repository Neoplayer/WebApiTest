using Home.Core.Models;

namespace Home.Core.Modules
{
    public class Neurohoop : ModuleBase
    {
        public Neurohoop(string pin) : base(pin)
        {
            ModuleType = EModule.Neurohoop;
            Name = "Neurohoop";
            ConnectionType = EConnectionType.UART;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}