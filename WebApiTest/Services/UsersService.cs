using Home.Core.Dto;
using Home.Core.Modules;
using WebApiTest.Dto;
using WebApiTest.Models;

namespace WebApiTest.Services;

public class UsersService : IUsersService
{
    
    private static List<User> users = new List<User>(); // TODO Storage in db. (Sqlite?)!!!!!
    
    
    public User? GetUser(string user, string password)
    {
        return users.FirstOrDefault(x => x.Name == user && x.Password == password);
    }

    public bool AddUser(User user)
    {
        users.Clear();

        users.Add(user);
        return true;
    }

    public List<string> GetUsers() => users.Select(x => x.Name).ToList();
    
    public List<ModuleBase>? GetUserModules(string user, string password) => users.FirstOrDefault(x => x.Name == user && x.Password == password)?.Modules;

    public bool UpdateModuleModule(UpdateModuleData data)
    {
        var user = users.FirstOrDefault(x => x.Name == data.user && x.Password == data.password);

        if (user == null)
        {
            return false;
        }
        
        user.CommandsQueue.Add(data.Command);
        
        var module = user.Modules.FirstOrDefault(x => x.Pin == data.Command.Pin);
        module.Value = data.Command.Value;
        
        return true;
    }
}