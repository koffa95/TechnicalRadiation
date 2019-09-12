using System.Collections.Generic;
using Models.DTO;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class NewsItemService
    {
        private NewsItemRepository _newsItemRepository  = new NewsItemRepository();

        public IEnumerable<NewsItemDto> GetAllNewsItems(int id)
        {
            return _newsItemRepository.GetAllNewsItems(id);
        }
    }
}