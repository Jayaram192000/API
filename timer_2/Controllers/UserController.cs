using Microsoft.AspNetCore.Mvc;
using timer_2.DTO;
using timer_2.Models;
using timer_2.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace timer_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsers();
            if (users is null || !users.Any())
            {
                return NotFound("No records found.");
            }
            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{name}")]
        public async Task<IActionResult> GetUserBYName(string name)
        {
            var users = await _userService.GetByName(name);
            if (users is null)
            {
                return NotFound("No records found.");
            }
            return Ok(users);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
        {
            var createuser = await _userService.CreateUser(userDto);
            if (createuser is null)
            {
                return NotFound("No records found.");
            }
            return Ok("User created succesfully");

        }

        // PUT api/<UserController>/5
        [HttpPut()]
        public async Task<IActionResult> UpdateUser([FromBody] UserDto userDto)
        {
            var createuser = await _userService.UpdateUser(userDto);
            if (createuser is null)
            {
                return NotFound("No records found.");
            }
            return Ok("User updated succesfully");
        }

        // DELETE api/<UserController>/5
        [HttpDelete()]
        public async Task<IActionResult> DeleteUser(string name)
        {
            var users = await _userService.DeleteUser(name);
            if (users is null)
            {
                return NotFound("No records found.");
            }
            return Ok("User deleted succesfully.");
        }
    }
}
