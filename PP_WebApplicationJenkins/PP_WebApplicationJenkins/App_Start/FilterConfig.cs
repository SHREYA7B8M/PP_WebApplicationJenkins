using System.Web;
using System.Web.Mvc;

namespace PP_WebApplicationJenkins
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
