using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NasaApplication.Models;
using NasaApplication.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NasaApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        private UserService userService;

        public UserController()
        {
            userService = new UserService();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AuthenticationUser(User user)
        {

            bool verified = userService.VerifiedUser(user);
            if(verified== true)
            {
                Response.Redirect("HomeUser.html");
                return Ok();
            }
            else{

                return BadRequest("Invalid data.");
            }

          
        }

        
    }
}
