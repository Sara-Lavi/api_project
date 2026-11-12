using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ApiProject.Entities;
using ApiProject.Services;
using Zxcvbn;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;

        public UsersController(IUserService userService, IPasswordService passwordService)
        {
            _userService = userService;
            _passwordService = passwordService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody]User user)
        {
            try
            {
                int  result = _passwordService.CheckStrongPass(user.Pass);
                if (result < 3)
                    throw new Exception("Password too weak");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            User user_1 = _userService.NewUser(user);
            return CreatedAtAction(nameof(Get), new { id = user_1.UserId }, user_1);
        }  

        [HttpPost("login")]
        public ActionResult Post([FromBody] LoginUser userlogin)
        { 
            User user = _userService.Login(userlogin);
            if(user != null)
                return Ok(user);
            return NoContent();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]User user)
        {
            try
            {
                int result = _passwordService.CheckStrongPass(user.Pass);
                if (result < 3)
                    throw new Exception("Password too weak");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            _userService.Update(id, user);
            return Ok();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
