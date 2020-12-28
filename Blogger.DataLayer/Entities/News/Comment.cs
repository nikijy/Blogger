using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Blogger.DataLayer.Entities.Users;

namespace Blogger.DataLayer.Entities.News
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Display(Name = "خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int NewsId { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Name { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        public string Email { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "متن نظر")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string NewsComment { get; set; }

        #region relations

        public virtual News News { get; set; }
        public virtual User User { get; set; }

        #endregion
    }

}
