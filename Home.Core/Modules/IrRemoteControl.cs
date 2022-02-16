using Home.Core.Models;

namespace Home.Core.Modules
{
    public class IrRemoteControl : ModuleBase
    {
        public IrRemoteControl(string pin) : base(pin)
        {
            ModuleType = EModule.IrRemoteControl;
            Name = "IrRemoteControl";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}