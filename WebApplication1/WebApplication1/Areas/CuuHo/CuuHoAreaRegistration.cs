using System.Web.Mvc;

namespace WebApplication1.Areas.CuuHo
{
    public class CuuHoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CuuHo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CuuHo_default",
                "CuuHo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}