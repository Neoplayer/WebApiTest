using Home.Core.Models;

namespace Home.Core.Modules
{
    public class Buzzer : ModuleBase
    {
        public Buzzer(string pin) : base(pin)
        {
            ModuleType = EModule.Buzzer;
            Name = "Buzzer";
            ConnectionType = EConnectionType.OUT;
            
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}