using Home.Core.Models;
using Home.Core.Modules;

namespace WebApiTest.Models
{
    public static class ModuleManager
    {
        public static ModuleBase GetModule(EModule eModule, string pin)
        {
            return eModule switch
            {
                EModule.IrRemoteControl => new IrRemoteControl(pin),
                EModule.IrOptocoupler => new IrOptocoupler(pin),
                EModule.ColorSensor => new ColorSensor(pin),
                EModule.DistanceSensor => new DistanceSensor(pin),
                EModule.LightSensor => new LightSensor(pin),
                EModule.Button => new Button(pin),
                EModule.TemperatureSensor => new TemperatureSensor(pin),
                EModule.MicrophoneAnalog => new MicrophoneAnalog(pin),
                EModule.ThresholdMicrophone => new ThresholdMicrophone(pin),
                EModule.PositionSensor => new PositionSensor(pin),
                EModule.ShaftAngleSensor => new ShaftAngleSensor(pin),
                EModule.TiltSensor => new TiltSensor(pin),
                EModule.ShockSensor => new ShockSensor(pin),
                EModule.FireSensor => new FireSensor(pin),
                EModule.MagneticFieldSensor => new MagneticFieldSensor(pin),
                EModule.BendingSensor => new BendingSensor(pin),
                EModule.Neurohoop => new Neurohoop(pin),
                EModule.HdCamera => new HdCamera(pin),
                EModule.DcMotor => new DcMotor(pin),
                EModule.ServoMotor => new ServoMotor(pin),
                EModule.Display => new Display(pin),
                EModule.Led => new Led(pin),
                EModule.Speaker => new Speaker(pin),
                EModule.Buzzer => new Buzzer(pin),
                EModule.AudioTrack => new AudioTrack(pin),
                _ => null
            };
        }

    }
}
