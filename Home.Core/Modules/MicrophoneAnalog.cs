using Home.Core.Models;

namespace Home.Core.Modules
{
    public class MicrophoneAnalog : ModuleBase
    {
        public MicrophoneAnalog(string pin) : base(pin)
        {
            ModuleType = EModule.MicrophoneAnalog;
            Name = "MicrophoneAnalog";
            ConnectionType = EConnectionType.IN;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}