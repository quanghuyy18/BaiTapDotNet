using System.Web;
using System.Web.Mvc;

namespace NguyenHuuQuangHuy_21103100456_A8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
