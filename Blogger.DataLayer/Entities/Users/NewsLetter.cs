using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blogger.DataLayer.Entities.Users
{
    public class NewsLetter
    {
        public NewsLetter()
        {
            
        }
        [Key]
        public int NewsLetterId { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        public string Email { get; set; }
        [Display(Name = "فعال است؟")]
        public bool Active { get; set; }
    }
}
