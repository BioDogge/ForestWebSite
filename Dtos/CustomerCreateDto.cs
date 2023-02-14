﻿namespace ForestWebSite.Dtos
{
	public class CustomerCreateDto
	{
		public string Name { get; set; } = string.Empty;

		public string Phone { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
	}
}