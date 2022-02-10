using Home.Core.Models;

namespace Home.Core.Modules
{
    public interface IModule
    {
        string GetPin();
        string GetName();
        EModule GetType();
    }
}
