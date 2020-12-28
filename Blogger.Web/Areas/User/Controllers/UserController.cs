using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Core.Services.Interfaces;
using Blogger.DataLayer.Entities.Users;

namespace Blogger.Web.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserByUserName(User.Identity.Name));
        }

        public IActionResult EditUser(int id)
        {
            return View(_userService.GetUserByUserId(id));
        }

        [HttpPost]
        public IActionResult EditUser(DataLayer.Entities.Users.User user,string optionsRadios)
        {
            if (optionsRadios == "enable")
            {
                user.IsActiveNewsLetter = true;
            }

            if (optionsRadios=="disable")
            {
                user.IsActiveNewsLetter = false;
            }
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            _userService.UpdateUser(user);
            return RedirectToAction("Index");
        }
    }
}
