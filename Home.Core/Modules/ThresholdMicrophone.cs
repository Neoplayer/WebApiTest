using Home.Core.Models;

namespace Home.Core.Modules
{
    public class ThresholdMicrophone : ModuleBase
    {
        public ThresholdMicrophone(string pin) : base(pin)
        {
            ModuleType = EModule.ThresholdMicrophone;
            Name = "ThresholdMicrophone";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}