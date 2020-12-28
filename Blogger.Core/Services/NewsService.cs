using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blogger.Core.DTOs.News;
using Blogger.Core.Services.Interfaces;
using Blogger.DataLayer.Context;
using Blogger.DataLayer.Entities.News;
using Microsoft.EntityFrameworkCore;

namespace Blogger.Core.Services
{
    public class NewsService : INewsService
    {
        private BloggerContext _context;

        public NewsService(BloggerContext context)
        {
            _context = context;
        }
        public int NewsCount()
        {
            return _context.News.Count();
        }

        public List<News> GetAllNews(int take = 0, int pageId = 1)
        {
            if (take == 0)
                take = 12;
            int skip = (pageId - 1) * take;
            return _context.News
                .Include(c => c.Category)
                .Skip(skip).Take(take)
                .ToList();
        }

        public News GetNewsById(int newsId)
        {
            return _context.News.Find(newsId);
        }

        public void UpdateNews(News news)
        {
            _context.News.Update(news);
            _context.SaveChanges();
        }

        public List<ShowPopularNewsViewModel> GetAllNewsForArchive(int take = 0, int pageId = 1)
        {
            if (take == 0)
                take = 8;
            int skip = (pageId - 1) * take;
            return _context.News
                .Include(c => c.Category)
                .Include(c => c.Comments)
                .Select(n => new ShowPopularNewsViewModel()
                {
                    NewsId = n.NewsId,
                    ImageName = n.ImageName,
                    CreateDate = n.CreateDate,
                    Likes = n.Likes,
                    ShortDescription = n.ShortDescription,
                    Title = n.Title,
                    Comments = n.Comments.Count
                })
                .Skip(skip).Take(take)
                .ToList();
        }

        public List<ShowRecentNewsViewModel> ShowRecentNews(int take = 6)
        {
            return _context.News
                .OrderByDescending(n => n.CreateDate)
                .Select(n => new ShowRecentNewsViewModel()
                {
                    NewsId = n.NewsId,
                    ImageName = n.ImageName,
                    CreateDate = n.CreateDate,
                    Title = n.Title
                }).Take(take).ToList();
        }

        public List<ShowPopularNewsViewModel> ShowPopularNews(int take = 4)
        {
            return _context.News
                .Include(n => n.Comments)
                .OrderByDescending(n => n.Visit)
                .Select(n => new ShowPopularNewsViewModel()
                {
                    NewsId = n.NewsId,
                    ImageName = n.ImageName,
                    CreateDate = n.CreateDate,
                    Likes = n.Likes,
                    ShortDescription = n.ShortDescription,
                    Title = n.Title,
                    Comments = n.Comments.Count
                }).Take(take).ToList();
        }

        public List<ShowTagsInArchiveViewModel> GetTagsForArchive()
        {
            return _context.News
                .OrderBy(n => n.Tags)
                .Select(n => new ShowTagsInArchiveViewModel()
                {
                    Tags = n.Tags
                }).ToList();
        }

        public List<ShowPopularNewsViewModel> SearchNews(string search,int take=0,int pageId=0)
        {
            if (take == 0)
                take = 8;
            int skip = (pageId - 1) * take;
            return
                _context.News.Where(
                    n =>
                        n.Title.Contains(search) ||
                        n.ShortDescription.Contains(search) ||
                        n.Tags.Contains(search) ||
                        n.Text.Contains(search)).Distinct()
                    .Select(n=>new ShowPopularNewsViewModel()
                    {
                        NewsId = n.NewsId,
                        ImageName = n.ImageName,
                        CreateDate = n.CreateDate,
                        Likes = n.Likes,
                        ShortDescription = n.ShortDescription,
                        Title = n.Title,
                        Comments = n.Comments.Count
                    })
                    .Skip(skip).Take(take).ToList();
        }

        public List<ShowPopularNewsViewModel> ShowNewsByCategoryId(int categoryId,int take=0,int pageId=1)
        {
            if (take == 0)
                take = 8;
            int skip = (pageId - 1) * take;
            return _context.News
                .Include(n => n.Category)
                .Where(n => n.CategoryId == categoryId)
                .Select(n => new ShowPopularNewsViewModel()
                {
                    NewsId = n.NewsId,
                    ImageName = n.ImageName,
                    CreateDate = n.CreateDate,
                    Likes = n.Likes,
                    ShortDescription = n.ShortDescription,
                    Title = n.Title,
                    Comments = n.Comments.Count
                })
                .Skip(skip).Take(take).ToList();
        }

        public List<ShowCategoryViewModel> GetAllCategories()
        {
            return _context.Categories.Select(n => new ShowCategoryViewModel()
            {
                Title = n.Title,
                CategoryId = n.CategoryId,
                Count = n.News.Count
            }).ToList();
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public IEnumerable<Comment> GetCommentByNewsId(int newsId)
        {
            return _context.Comments
                .Include(n=>n.News)
                .Where(c => c.NewsId == newsId);
        }
    }
}
