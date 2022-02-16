using Home.Core.Models;

namespace Home.Core.Modules
{
    public class ServoMotor : ModuleBase
    {
        public ServoMotor(string pin) : base(pin)
        {
            ModuleType = EModule.ServoMotor;
            Name = "ServoMotor";
            ConnectionType = EConnectionType.OUT;
            ValueType = typeof(int);
            ValueMaxInt = 180;
            ValueMinInt = 0;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}