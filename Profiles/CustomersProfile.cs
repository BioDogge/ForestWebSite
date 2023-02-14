using AutoMapper;
using ForestWebSite.Dtos;
using ForestWebSite.Models;

namespace ForestWebSite.Profiles
{
	public class CustomersProfile : Profile
	{
		public CustomersProfile()
		{
			CreateMap<CustomerCreateDto, Customer>();
		}
	}
}