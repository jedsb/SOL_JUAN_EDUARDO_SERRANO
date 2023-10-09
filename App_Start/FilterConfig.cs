using System.Web;
using System.Web.Mvc;

namespace SOL_JUAN_EDUARDO_SERRANO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
