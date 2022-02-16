using Home.Core.Models;

namespace Home.Core.Modules
{
    public class HdCamera : ModuleBase
    {
        public HdCamera(string pin) : base(pin)
        {
            ModuleType = EModule.HdCamera;
            Name = "HdCamera";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}