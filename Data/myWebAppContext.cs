using Microsoft.EntityFrameworkCore;
using myWebApp.Models;

namespace myWebApp.Data
{
    public class myWebAppContext : DbContext
    {
        public myWebAppContext (DbContextOptions<myWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}