using WebApiTest.Modules;

namespace WebApiTest.Models
{
    public static class ModuleManager
    {
        public static IModule GetModule(EModule eModule, string pin)
        {
            return eModule switch
            {
                EModule.LED => new LedModule(pin),
                _ => null
            };
        }

    }
}
