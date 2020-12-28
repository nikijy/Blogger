using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blogger.Core.DTOs.News
{
    #region news

    public class ShowRecentNewsViewModel
    {
        public int NewsId { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(100)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }
    }

    public class ShowPopularNewsViewModel
    {
        public int NewsId { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(100)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "تصویر")]
        public string ImageName { get; set; }
        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(350)]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "تعداد لایک ها")]
        public int Likes { get; set; }
        [Display(Name = "تعداد کامنت ها")]
        public int Comments { get; set; }

    }

    public class ShowTagsInArchiveViewModel
    {
        [Display(Name = "کلمات کلیدی")]
        public string Tags { get; set; }
    }

    #endregion

    #region categories

    public class ShowCategoryViewModel
    {
        public int CategoryId { get; set; }
        [Display(Name = "عنوان دسته بندی")]
        public string Title { get; set; }
        public int Count { get; set; }
    }

    #endregion
}
