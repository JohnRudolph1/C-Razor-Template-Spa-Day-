using SpaDay.Models;

using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Controllers
{
    public class UserController : Controller

    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (verify == newUser.Password)
            {
                ViewBag.user = newUser.Username;
                return View("Index");
            }

            else
            {
                ViewBag.error = "Both Passwords Must Match";
                return View("Add");
            }
        }
    }
}

