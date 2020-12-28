using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Blogger.DataLayer.Entities.News;

namespace Blogger.DataLayer.Entities.Users
{
   public class User
    {
        public User()
        {
            
        }

        [Key]
        public int UserId { get; set; }
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        public string Email { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Password { get; set; }
        [Display(Name = "کد فعالسازی")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string ActiveCode { get; set; }
        [Display(Name = "زندگی نامه")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Biography { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        public DateTime? RegisterDate { get; set; }
        [Display(Name = "ارسال خبرنامه")]
        public bool? IsActiveNewsLetter { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool? IsDeleted { get; set; }

        #region relations

        public virtual List<News.News> News { get; set; }
        public virtual List<Comment> Comments { get; set; }

        #endregion
    }
}
