using System.Web.Mvc;

namespace JobPortal.Areas.FrontEnd
{
    public class FrontEndAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FrontEnd";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FrontEnd_default",
                "FrontEnd/{controller}/{action}/{id}",
                new { Controller = "Account", action = "SignIN", id = UrlParameter.Optional },
                namespaces: new[] { "JobPortal.Areas.FrontEnd.Controllers" }
            );
        }
    }
}