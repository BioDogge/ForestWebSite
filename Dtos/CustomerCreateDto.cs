using System.ComponentModel.DataAnnotations;

namespace ForestWebSite.Dtos
{
	public class CustomerCreateDto
	{
		[Required]
		public string Name { get; set; } = string.Empty;

		[Required]
		[RegularExpression(@"^\+7-\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must match the '+7-xxx-xxx-xxxx' template")]
		public string Phone { get; set; } = string.Empty;

		[Required]
		public string Email { get; set; } = string.Empty;

		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
	}
}