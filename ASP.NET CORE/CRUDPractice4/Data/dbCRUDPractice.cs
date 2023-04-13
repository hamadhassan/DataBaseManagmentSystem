using CRUDPractice4.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUDPractice4.Data
{
	public class dbCRUDPractice : DbContext
	{
		public dbCRUDPractice(DbContextOptions options) : base(options)
		{

		}
		public DbSet<Students> Students { get; set; }
	}
}
