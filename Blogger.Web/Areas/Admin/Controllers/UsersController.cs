using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Core.Senders;
using Blogger.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blogger.DataLayer.Context;
using Blogger.DataLayer.Entities.Users;

namespace Blogger.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly BloggerContext _context;
        private IUserService _userService;

        public UsersController(BloggerContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        // GET: Admin/Users
        public async Task<IActionResult> Index(int pageId=1)
        {
            int count = _userService.UserCount();
            ViewBag.count = count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = count / 12;
            return View(_userService.GetAllUsers(12,pageId));
        }

        // GET: Admin/Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            user.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #region newsletter
        public IActionResult NewsLetter()
        {
            return View();
        }
        public IActionResult SendEmailForNewsLetter(string bodyText)
        {
            var newsLetters = _userService.GetAllEmails();
            string emails = null;
            foreach (var item in newsLetters)
            {
                emails = item.Email;
                string body = bodyText;
                SendEmail.Send(emails, "خبرنامه", body);
            }

            TempData["success"] = "با موفقیت ارسال شد";
            return View("NewsLetter");

        }


        #endregion
    }
}
