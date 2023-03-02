using Negosud.MVCWeb;
using Negosud.MVCWeb.Controllers;
using Negosud.MVCWeb.Services;
using Negosud.MVCWeb.Services.Model;

internal class Program
{
	private static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddControllersWithViews();
        builder.Services.AddSingleton<RESTAPIService>();
        builder.Services.AddSingleton<Model>();
		builder.Services.AddSingleton<BasketController>();

        var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Home/Error");
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseAuthorization();

		Routing.GetInstance().GenerateRoutes(app);

		app.Run();
	}
}