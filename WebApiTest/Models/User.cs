using Home.Core.Dto;
using Home.Core.Modules;
using WebApiTest.Dto;

namespace WebApiTest.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<ModuleBase> Modules { get; set; }


        public List<Command> CommandsQueue = new List<Command>();
    }
}
