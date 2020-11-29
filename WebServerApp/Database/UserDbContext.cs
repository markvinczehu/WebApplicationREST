
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebServerApp.Data.AuthData;
using WebServerApp.Data.Model;


namespace WebServerApp.Database
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Person> Persons { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DNP1.db");
        }
    }
}