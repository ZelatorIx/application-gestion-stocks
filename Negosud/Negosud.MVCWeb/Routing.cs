namespace Negosud.MVCWeb
{
	public class Routing
	{
		public static void GenerateRoutes(WebApplication app)
		{
			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}"
			);

			app.MapControllerRoute(
				name: "Item",
				pattern: "{controller=Item}/{action=Index}/{id?}"
			);
		}
	}
}
