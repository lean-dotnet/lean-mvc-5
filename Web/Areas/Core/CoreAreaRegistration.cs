using System.Web.Mvc;

namespace Web.Areas.Core
{
    public class CoreAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Core";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Core_Default",
                "",
                new { controller = "Home", action = "Index" }
            );
        }
    }
}
