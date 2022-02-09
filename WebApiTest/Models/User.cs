using WebApiTest.Dto;
using WebApiTest.Modules;

namespace WebApiTest.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<IModule> Modules { get; set; }


        public List<Command> CommandsQueue = new List<Command>();
    }
}
