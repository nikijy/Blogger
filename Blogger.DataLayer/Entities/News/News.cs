using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Blogger.DataLayer.Entities.Users;

namespace Blogger.DataLayer.Entities.News
{
   public class News
    {
        public News()
        {
            
        }
        [Key]
        public int NewsId { get; set; }

        [Display(Name = "گروه خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CategoryId { get; set; }

        [Display(Name = "عنوان")]
        [MaxLength(100)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(350)]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
       
        public string Text { get; set; }

        [Display(Name = "بازدید")]
        public int Visit { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Tags { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool IsDeleted { get; set; }
        [Display(Name = "پسندیده شده؟")]
        public bool IsLiked { get; set; }
        [Display(Name = "تعداد لایک ها")]  
        public int Likes { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual User User { get; set; }
    }
}
