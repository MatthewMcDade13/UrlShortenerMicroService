using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UrlShortenerMicroService.Models
{
    public class UrlContext : DbContext
    {
        public DbSet<Url> Urls { get; set; }
        private IConfigurationRoot config;

        public UrlContext(IConfigurationRoot config, DbContextOptions options) 
            : base(options)
        {
            this.config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql(config["Data:UrlContextConnection"]);
        }
    }
}
