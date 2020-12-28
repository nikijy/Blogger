using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Core.Services.Interfaces;
using Blogger.DataLayer.Entities.News;

namespace Blogger.Web.Controllers
{
    public class News : Controller
    {
        private INewsService _newsService;

        public News(INewsService newsService)
        {
            _newsService = newsService;
        }
        public IActionResult Archive(int pageId = 1)
        {
            int count = _newsService.NewsCount();
            ViewBag.count = count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = count / 8;
            return View(_newsService.GetAllNewsForArchive(8, pageId));
        }
        [Route("Group/{id}/{title}")]
        public ActionResult ShowNewsByCategoryId(int id, string title, int pageId = 1)
        {
            int count = _newsService.NewsCount();
            ViewBag.count = count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = count / 8;

            ViewBag.name = title;
            return View(_newsService.ShowNewsByCategoryId(id));
        }

        public IActionResult ShowNews(int id)
        {
            var news = _newsService.GetNewsById(id);
            if (news == null)
            {
                return NotFound();
            }
            else
            {
                news.Visit += 1;
                _newsService.UpdateNews(news);
            }

            return View(news);
        }

        public IActionResult Command(int id, string command)
        {
            var news = _newsService.GetNewsById(id);
            
            switch (command)
            {
                case "liked":
                    {
                        news.Likes += 1;
                        _newsService.UpdateNews(news);
                        break;
                    }
                case "unliked":
                    {
                        news.Likes -= 1;
                        _newsService.UpdateNews(news);


                        break;
                    }
            }
            return RedirectToAction("ShowNews",new {id});
        }
        public ActionResult AddComment(int id, string name, string email, string comment)
        {
            if (!ModelState.IsValid)
            {
                return View("ShowNews");
            }
            Comment addcomment = new Comment()
            {
                NewsId = id,
                CreateDate = DateTime.Now,
                NewsComment = comment,
                Email = email,
                Name = name,
            };
            _newsService.AddComment(addcomment);

            return PartialView("Components/ShowCommentsComponent/_ShowComments", _newsService.GetCommentByNewsId(id));

        }

    }
}
