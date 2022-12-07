using System.Web.Mvc;
using System.Web.Routing;

namespace Web.App_Start
{
  public class Routing
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.MapRoute(
          name: "Home",
          url: "",
          defaults: new { controller = "Home", action = "Index" }
      );
    }
  }
}
