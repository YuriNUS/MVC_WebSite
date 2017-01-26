using System.Web;
using System.Web.Mvc;

namespace LogicUniversity__AD_T4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
