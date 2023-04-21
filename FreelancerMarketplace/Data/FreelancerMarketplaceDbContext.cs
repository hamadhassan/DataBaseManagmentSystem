using FreelancerMarketplace.Models.Domain;
using Microsoft.EntityFrameworkCore;
using FreelancerMarketplace.Models.View;

namespace FreelancerMarketplace.Data
{
	public class FreelancerMarketplaceDbContext : DbContext
	{
		public FreelancerMarketplaceDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Crediational> crediationals { get; set; }
		public DbSet<FreelancerMarketplace.Models.View.UpdateCrediational> UpdateCrediational { get; set; } = default!;
	}
}
