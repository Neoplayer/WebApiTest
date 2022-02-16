using Home.Core.Models;

namespace Home.Core.Modules
{
    public class BendingSensor : ModuleBase
    {
        public BendingSensor(string pin) : base(pin)
        {
            ModuleType = EModule.BendingSensor;
            Name = "BendingSensor";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}