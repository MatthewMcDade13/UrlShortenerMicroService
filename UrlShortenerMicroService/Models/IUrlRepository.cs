using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
