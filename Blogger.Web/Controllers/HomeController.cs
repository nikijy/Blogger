using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Core.Services.Interfaces;
using Blogger.DataLayer.Entities.Users;

namespace Blogger.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private INewsService _newsService;

        public HomeController(IUserService userService, INewsService newsService)
        {
            _userService = userService;
            _newsService = newsService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmailForNewsLetter(NewsLetter news)
        {

            if (ModelState.IsValid)
            {
                if (_userService.IsExistEmailForNewsLetter(news.Email))
                {
                    TempData["error"] = "این ایمیل قبلا ثبت شده است";
                    return View("Index");
                }

                news.Active = true;
                _userService.AddEmail(news);
                _userService.Save();
                TempData["message"] = "ایمیل شما با موفقیت ثبت شد";
            }
            return RedirectToAction("Index");
        }
        public IActionResult Search(string q, int pageId = 1)
        {
            int count = _newsService.NewsCount();
            ViewBag.count = count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = count / 8;

            ViewBag.Name = q;
            return View(_newsService.SearchNews(q,8,pageId));
        }
    }
}
