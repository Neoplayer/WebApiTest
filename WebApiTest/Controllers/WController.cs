using Home.Core.Dto;
using Home.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApiTest.Dto;
using WebApiTest.Models;
using WebApiTest.Services;

namespace WebApiTest.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class WController : ControllerBase
    {
        private readonly ILogger<WController> _logger;
        private readonly IUsersService _usersService;

        public WController(ILogger<WController> logger, IUsersService userService, IUsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        [HttpGet("Register")]
        public IActionResult Register(string d)
        {
            var data = d.Split('|');

            var user = data[0];
            var password = data[1];
            var modules = data[2];

            _usersService.AddUser(new User()
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
            return Ok(_usersService.GetUsers());
        }

        [HttpGet("GetUsersSensors")]
        public IActionResult GetUsersModules(string user, string password)
        {
            var modules = _usersService.GetUserModules(user, password);

            var response = JsonConvert.SerializeObject(modules);
            
            return Ok(response);
        }
        
        [HttpPost("UpdateModuleStatus")]
        public IActionResult UpdateModuleStatus(UpdateModuleData data)
        {
            var result = _usersService.UpdateModuleModule(data);

            return Ok(result);
        }

        // Resp template: Pin:Value,Pin:Value,Pin:Value,.....
        [HttpPost("Ping")]
        public IActionResult Ping(PingData data)
        {
            var user = _usersService.GetUser(data.User, data.Password);
            
            if (user == null)
                return BadRequest(new { message = "User not found" });


            // handle data


            var response = string.Join(',', user.CommandsQueue.Select(x => x.Pin + ":" + x.Value));
            user.CommandsQueue.Clear();

            return Ok(response);
        }
    }
}