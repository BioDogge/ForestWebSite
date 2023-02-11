using ForestWebSite.Data;
using Microsoft.EntityFrameworkCore;

namespace ForestWebSite
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<AppDbContext>(opts =>
				opts.UseInMemoryDatabase("InMemoryForestDB"));

			builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.MapDefaultControllerRoute();

			app.Run();
		}
	}
}