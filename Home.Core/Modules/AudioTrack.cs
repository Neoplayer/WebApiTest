using Home.Core.Models;

namespace Home.Core.Modules
{
    public class AudioTrack : ModuleBase
    {
        public AudioTrack(string pin) : base(pin)
        {
            ModuleType = EModule.AudioTrack;
            Name = "AudioTrack";
            ConnectionType = EConnectionType.UART;
        }

        public string GetPin() => Pin;
        public EModule GetType() => ModuleType;
        public string GetName() => Name;
    }
}