using ForestWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace ForestWebSite.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> opts)
			: base(opts) { }

		public DbSet<Customer> Customers { get; set; }
	}
}