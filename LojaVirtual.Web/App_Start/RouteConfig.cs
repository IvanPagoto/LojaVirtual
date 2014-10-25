using System.Web.Mvc;
using System.Web.Routing;

namespace LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            /*ROTAS:
             * 1 = /
             * 2 = Pagina2
             * 3 = Futebol
             * 4 = Futebol/Pagina2
            */

            // 1 - Inicio
            routes.MapRoute(null, "", new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null, pagina = 1 });

            // 2 
            routes.MapRoute(null, "Pagina{pagina}", new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null }, new { pagina = @"\d+" });

            // 3
            routes.MapRoute(null, "{categoria}", new {controller = "Vitrine", action = "ListaProdutos", pagina = 1});

            //4
            routes.MapRoute(null, "{categoria}Pagina{pagina}", new { controller = "Vitrine", action = "ListaProdutos" }, new { pagina = @"\d+" });

            //default
            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
