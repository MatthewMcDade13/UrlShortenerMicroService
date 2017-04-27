using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortenerMicroService.Models
{
    public class UrlRepository : IUrlRepository
    {
        UrlContext context;

        public UrlRepository(UrlContext context)
        {
            this.context = context;
        }

        public IEnumerable<Url> GetAllUrls()
        {
            return context.Urls.ToList();
        }

        public List<Url> GetUrlById(long id)
        {
            return GetAllUrls()
                .Where(model => model.Id == id)
                .ToList();
        }

        public void AddUrl(Url url)
        {
            context.Add(url);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await context.SaveChangesAsync()) > 0;
        }
    }
}
