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
    }
}
