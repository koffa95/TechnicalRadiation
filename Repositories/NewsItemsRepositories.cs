using System.Collections.Generic;
using System.Linq;
using Repositories.Data;
using Models.DTO;
using Models.Entities;

namespace TechnicalRadiation.Repositories
{
    public class NewsItemRepository
    {
        public IEnumerable<NewsItemDto> GetAllNewsItems()
        {
            IEnumerable<NewsItem> res = DataProvider.NewsItem.Select(r => new NewsItem
            {
                Id = r.Id,
                Title = r.Title,
                ImgSource = r.ImgSource,
                ShortDescription = r.ShortDescription,
                PublishDate = r.PublishDate
            }).OrderByDescending(NewsItem => NewsItem.PublishDate);
            
            ///IEnumerable<NewsItemDto> result = res as IEnumerable<NewsItemDto>;

            return res.Select(r => new NewsItemDto
            {
                Id = r.Id,
                Title = r.Title,
                ImgSource = r.ImgSource,
                ShortDescription = r.ShortDescription
            });
        }
    }
}