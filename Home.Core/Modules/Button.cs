using Home.Core.Models;

namespace Home.Core.Modules
{
    public class Button : ModuleBase
    {
        public Button(string pin) : base(pin)
        {
            ModuleType = EModule.Button;
            Name = "Button";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}