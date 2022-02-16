using Home.Core.Models;

namespace Home.Core.Modules
{
    public class Speaker : ModuleBase
    {
        public Speaker(string pin) : base(pin)
        {
            ModuleType = EModule.Speaker;
            Name = "Speaker";
            ConnectionType = EConnectionType.OUT;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}