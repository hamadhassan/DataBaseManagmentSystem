using CRUDPractice.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUDPractice.Data
{
    public class CRUDPracticeDbContext : DbContext
    {
        public CRUDPracticeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }   
    }
}
