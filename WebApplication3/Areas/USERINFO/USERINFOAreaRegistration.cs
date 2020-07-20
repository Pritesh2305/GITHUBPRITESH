using System.Web.Mvc;

namespace WebApplication3.Areas.USERINFO
{
    public class USERINFOAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "USERINFO";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "USERINFO_default",
                "USERINFO/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}