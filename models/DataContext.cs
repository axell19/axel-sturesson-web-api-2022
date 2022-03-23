using Microsoft.EntityFrameworkCore;

namespace axel_sturesson_web_api_2022.models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Game> games {get; set;}
    }
}