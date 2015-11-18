using System.Web;
using System.Web.Mvc;

namespace TP_B3_EPSI_2015
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
