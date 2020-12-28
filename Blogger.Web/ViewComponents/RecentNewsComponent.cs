using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.Web.ViewComponents
{
    public class RecentNewsComponent:ViewComponent
    {
        private INewsService _newsService;

        public RecentNewsComponent(INewsService newsService)
        {
            _newsService = newsService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_RecentNews", _newsService.ShowRecentNews(6)));
        }
       
    }
}
