using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
    }
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Test([FromQuery]string username)
        {
            return new JsonResult(username);
            
        }

        [HttpPost]
        public IActionResult Test2([FromBody]User user)
        {
            return new JsonResult(user);
        }
    }
}