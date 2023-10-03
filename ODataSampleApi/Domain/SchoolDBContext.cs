using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ODataSampleApi.Data;

namespace ODataSampleApi.Domain
{
    public class SchoolDBContext:IdentityDbContext<ApplicationUser>
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options):base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set;}
    }
}
