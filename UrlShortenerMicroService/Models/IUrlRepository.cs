using System.Collections.Generic;
using System.Threading.Tasks;

namespace UrlShortenerMicroService.Models
{
    public interface IUrlRepository
    {
        IEnumerable<Url> GetAllUrls();

        List<Url> GetUrlById(long id);

        void AddUrl(Url url);

        Task<bool> SaveChangesAsync();
    }
}
