using System;
using System.Collections.Generic;
using System.Text;
using Blogger.Core.DTOs.News;
using Blogger.DataLayer.Entities.News;

namespace Blogger.Core.Services.Interfaces
{
   public interface INewsService
   {
        #region news
        int NewsCount();
        List<News> GetAllNews(int take = 0, int pageId = 1);
        News GetNewsById(int newsId);
        void UpdateNews(News news);
        List<ShowPopularNewsViewModel> GetAllNewsForArchive(int take = 0, int pageId = 1);
        List<ShowRecentNewsViewModel> ShowRecentNews(int take = 6);
        List<ShowPopularNewsViewModel> ShowPopularNews(int take = 4);
        List<ShowTagsInArchiveViewModel> GetTagsForArchive();
        List<ShowPopularNewsViewModel> SearchNews(string search,int take=0,int pageId=1);
        List<ShowPopularNewsViewModel> ShowNewsByCategoryId(int categoryId,int take=0,int pageId=1);

        #endregion

        #region Category

        List<ShowCategoryViewModel> GetAllCategories();


        #endregion

        #region comments

        void AddComment(Comment comment);
        IEnumerable<Comment> GetCommentByNewsId(int newsId);


        #endregion
   }
}
