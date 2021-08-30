using System.Web;
using System.Web.Mvc;

namespace Assignment1_EntityFrameworkAsp.NetMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
