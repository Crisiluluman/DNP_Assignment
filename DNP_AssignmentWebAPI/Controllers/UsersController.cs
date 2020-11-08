using System;
using System.Threading.Tasks;
using DNP_Assignment.Data;
using DNP_AssignmentWebAPI.Models;
using DNP_AssignmentWebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace DNP_AssignmentWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class UsersController : Controller
    {
        private IUserCloudService iUserCloudService;

        public UsersController(IUserCloudService iUserCloudService)
        {
            this.iUserCloudService = iUserCloudService;
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string UserName, string Password)
       {
           try
           {
               User user = await iUserCloudService.ValidateUserAsync(UserName, Password);
               return Ok(user);
               //return Created(user);
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               return StatusCode(500, e.Message);
           }
       }
    }
}