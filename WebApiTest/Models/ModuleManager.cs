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
                EModule.LED => new LedModule(pin),
                _ => null
            };
        }

    }
}
