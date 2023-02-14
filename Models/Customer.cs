using System.ComponentModel.DataAnnotations;

namespace ForestWebSite.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public string Phone { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public DateTime CreatedDateTime { get; set; }
	}
}