using Home.Core.Models;

namespace Home.Core.Modules
{
    public class Led : ModuleBase
    {
        public Led(string pin) : base(pin)
        {
            ModuleType = EModule.Led;
            Name = "Led";
            ConnectionType = EConnectionType.OUT;
            ValueType = typeof(bool);
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}