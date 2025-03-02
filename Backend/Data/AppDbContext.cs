using Backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity;

namespace Backend.Data
{
    public class AppDbContext : DbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        
    }

}
