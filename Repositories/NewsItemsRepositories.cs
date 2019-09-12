using System.Collections.Generic;
using System.Linq;
using Repositories.Data;
using Models.DTO;
using Models.Entities;

namespace TechnicalRadiation.Repositories
{
    public class NewsItemRepository
    {
        public IEnumerable<NewsItemDto> GetAllNewsItems(int id)
        {
            return DataProvider.NewsItem.Select(r => new NewsItemDto
            {
                Id = r.Id,
                Title = r.Title,
                ImgSource = r.ImgSource,
                ShortDescription = r.ShortDescription
            });
        }
    }
}