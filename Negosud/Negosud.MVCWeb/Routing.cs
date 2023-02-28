namespace Negosud.MVCWeb
{
	public class Routing
	{
		private static Routing? instance;
		private WebApplication? app;

        private Routing()
		{
		}

		public static Routing GetInstance()
		{
            if (instance == null)
            {
                instance = new Routing();
            }
            return instance;
        }

		public void GenerateRoutes(WebApplication application)
		{
			app = application;

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}"
			);

			MapItems();
		}

		private void MapItems()
		{
			// Liste de tous les articles
            app?.MapControllerRoute(
                name: "Item",
                pattern: "{controller=Item}/{action=Index}"
            );
			// Détails d'un article
            app?.MapControllerRoute(
                name: "ItemDetails",
                pattern: "{controller=Item}/{action=Details}/{id}"
            );
        }
	}
}
