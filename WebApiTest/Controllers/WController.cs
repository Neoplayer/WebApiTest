using Microsoft.AspNetCore.Mvc;
using WebApiTest.Dto;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WController : ControllerBase
    {
        private static List<User> users = new List<User>(); // TODO UsersService!!!!!


        private readonly ILogger<WController> _logger;

        public WController(ILogger<WController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Register")]
        public IActionResult Register(string d)
        {
            var data = d.Split('|');

            var user = data[0];
            var password = data[1];
            var modules = data[2];

            users.Add(new User()
            {
                Name = user,
                Password = password,
                Modules = modules.Split(',').Select(x =>
                {
                    var module = x.Split(':');

                    var moduleName = Enum.Parse<EModule>(module[0]);
                    var pin = module[1];

                    return ModuleManager.GetModule(moduleName, pin);
                }).ToList()
            });

            return Ok();
        }

        [HttpGet("Users")]
        public IActionResult Users()
        {
            return Ok(users.Select(x => x.Name));
        }


        // Resp template: Pin:Value,Pin:Value,Pin:Value,.....
        [HttpPost("Ping")]
        public IActionResult Ping(PingData data)
        {
            var user = users.FirstOrDefault(x => x.Name == data.User);

            if (user == null)
                return BadRequest(new { message = "User not found" });


            // handle data


            var response = string.Join(',', user.CommandsQueue.Select(x => x.Pin + ":" + x.Value));
            user.CommandsQueue.Clear();

            return Ok(response);
        }
    }
}