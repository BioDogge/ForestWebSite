using ForestWebSite.Models;

namespace ForestWebSite.Data
{
	public interface ICustomerRepo
	{
		void CreateCustomer(Customer customer);

		bool SaveChanges();
	}
}