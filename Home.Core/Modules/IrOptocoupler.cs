using Home.Core.Models;

namespace Home.Core.Modules
{
    public class IrOptocoupler : ModuleBase
    {
        public IrOptocoupler(string pin) : base(pin)
        {
            ModuleType = EModule.IrOptocoupler;
            Name = "IrOptocoupler";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}