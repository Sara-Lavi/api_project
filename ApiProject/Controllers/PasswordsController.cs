using Microsoft.AspNetCore.Mvc;
using Zxcvbn;
using ApiProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordsController : ControllerBase
    {
        private readonly IPasswordService _passwordService;

        public PasswordsController(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }


        // GET: api/<PasswordsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PasswordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PasswordsController>
        [HttpPost]
        public IActionResult Post([FromBody] string pass)
        { 
            return Ok(_passwordService.CheckStrongPass(pass));
        }

        // PUT api/<PasswordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PasswordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
