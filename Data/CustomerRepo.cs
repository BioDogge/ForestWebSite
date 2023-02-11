using ForestWebSite.Models;

namespace ForestWebSite.Data
{
	public class CustomerRepo : ICustomerRepo
	{
		private readonly AppDbContext _context;

		public CustomerRepo(AppDbContext context)
		{
			_context = context;
		}

		public void CreateCustomer(Customer customer)
		{
			_context.Customers.Add(customer);
		}

		public bool SaveChanges()
		{
			return _context.SaveChanges() >= 0;
		}
	}
}