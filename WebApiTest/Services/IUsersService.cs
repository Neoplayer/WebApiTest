using Home.Core.Dto;
using Home.Core.Modules;
using WebApiTest.Models;

namespace WebApiTest.Services;

public interface IUsersService
{
    User? GetUser(string user, string password);
    bool AddUser(User user);
    List<string> GetUsers();
    List<ModuleBase>? GetUserModules(string user, string password);
    bool UpdateModuleModule(UpdateModuleData data);
}