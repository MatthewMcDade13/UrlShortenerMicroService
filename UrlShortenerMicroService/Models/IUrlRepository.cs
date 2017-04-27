using System.Collections.Generic;
using System.Threading.Tasks;

namespace UrlShortenerMicroService.Models
{
    public interface IUrlRepository
    {
        IEnumerable<Url> GetAllUrls();

        void AddUrl(Url url);

        Task<bool> SaveChangesAsync();
    }
}
