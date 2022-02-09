namespace WebApiTest.Modules
{
    public class LedModule : IModule
    {
        public string GetName() => "Led";
        public string GetPin() => _pin;

        private string _pin;

        public LedModule(String pin)
        {
            _pin = pin;
        }
    }
}
