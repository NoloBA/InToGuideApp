using InToGuideWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InToGuideWebAPI.Data
{
    public class InToGuideContext :DbContext
    {
        public InToGuideContext(DbContextOptions options)
           : base(options)
        {



        }

        public DbSet<User> Users { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Certificate> Certificates { get; set; }

    }
}
