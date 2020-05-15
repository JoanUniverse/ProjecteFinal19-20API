using System.Web;
using System.Web.Mvc;

namespace ProjecteFinal19_20API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
