using System.Web;
using System.Web.Mvc;

namespace NewHealthgrades.Oas.Webapi.Oas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
