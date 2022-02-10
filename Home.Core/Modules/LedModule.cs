using Home.Core.Models;

namespace Home.Core.Modules
{
    public class LedModule : ModuleBase 
    {
        public LedModule(string pin) : base(pin)
        {
            ModuleType = EModule.LED;
            Name = "LED";
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}
