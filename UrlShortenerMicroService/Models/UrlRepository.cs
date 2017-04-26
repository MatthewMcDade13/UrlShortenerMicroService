using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
