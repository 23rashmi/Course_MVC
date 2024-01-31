using System.Web;
using System.Web.Mvc;

namespace WebAppMVC_Course
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
