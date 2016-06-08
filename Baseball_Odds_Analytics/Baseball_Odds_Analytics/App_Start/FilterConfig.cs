using System.Web;
using System.Web.Mvc;

namespace Baseball_Odds_Analytics
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
