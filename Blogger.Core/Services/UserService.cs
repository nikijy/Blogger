using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blogger.Core.Convertors;
using Blogger.Core.DTOs.Users;
using Blogger.Core.Generator;
using Blogger.Core.Security;
using Blogger.Core.Services.Interfaces;
using Blogger.DataLayer.Context;
using Blogger.DataLayer.Entities.Users;

namespace Blogger.Core.Services
{
   public class UserService:IUserService
   {
       private BloggerContext _context;

       public UserService(BloggerContext context)
       {
           _context = context;
       }

       public List<User> GetAllUsers(int take = 0, int pageId = 1)
       {
           if (take == 0)
               take = 12;
           int skip = (pageId - 1) * take;
           return _context.Users.OrderBy(u => u.UserName)
               .Skip(skip).Take(take)
               .ToList();
       }

       public int UserCount()
       {
           return _context.Users.Count();
       }

       public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public int AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public User LoginUser(LoginViewModel login)
        {
            string password = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedText.FixEmail(login.Email);
            return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }


        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqCode();
            _context.SaveChanges();

            return true;
        }

        public User GetUserByUserName(string userName)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == userName);
        }

        public User GetUserByUserId(int userId)
        {
            return _context.Users.Find(userId);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<NewsLetter> GetAllEmails()
        {
            return _context.NewsLetters.Where(n=>n.Active).ToList();
        }

        public bool AddEmail(NewsLetter newsLetter)
        {
            try
            {
                _context.NewsLetters.Add(newsLetter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsExistEmailForNewsLetter(string email)
        {
            return _context.NewsLetters.Any(n => n.Email == email);
        }
    }
}
