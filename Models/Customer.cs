using System.ComponentModel.DataAnnotations;

namespace ForestWebSite.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		//[Required]
		public string Name { get; set; } = string.Empty;

		//[Required]
		//[RegularExpression(@"^\+7-\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone Number must match the '+7-xxx-xxx-xxxx' template")]
		public string Phone { get; set; } = string.Empty;

		//[Required]
		//[RegularExpression(@"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)", ErrorMessage = "Email address is incorrect")]
		public string Email { get; set; } = string.Empty;

		public DateTime CreatedDateTime { get; set; }
	}
}