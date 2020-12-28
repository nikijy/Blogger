using System;
using System.Collections.Generic;
using System.Text;
using Blogger.Core.DTOs.Users;
using Blogger.DataLayer.Entities.Users;

namespace Blogger.Core.Services.Interfaces
{
   public interface IUserService
   {
       List<User> GetAllUsers(int take = 0, int pageId = 1);
       int UserCount();
        bool IsExistEmail(string email);
        bool IsExistUserName(string userName);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string activeCode);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);
        User GetUserByUserName(string userName);
        User GetUserByUserId(int userId);
        void Save();

        #region newsletter

        List<NewsLetter> GetAllEmails();
        bool AddEmail(NewsLetter newsLetter);
        bool IsExistEmailForNewsLetter(string email);

        #endregion

    }
}
