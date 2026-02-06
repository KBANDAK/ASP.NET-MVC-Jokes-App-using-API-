using System.Web;
using System.Web.Mvc;

namespace khaderbandak_202311342
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
