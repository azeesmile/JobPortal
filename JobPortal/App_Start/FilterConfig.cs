using System.Web.Mvc;

namespace JobPortal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            //filters.Add(new CustomHandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
        }
    }
}
