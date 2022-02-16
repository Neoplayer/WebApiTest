using Home.Core.Models;

namespace Home.Core.Modules
{
    public class DcMotor : ModuleBase
    {
        public DcMotor(string pin) : base(pin)
        {
            ModuleType = EModule.DcMotor;
            Name = "DcMotor";
            ConnectionType = EConnectionType.M;
            ValueType = typeof(int);
            ValueMaxInt = 100;
            ValueMinInt = -100;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}