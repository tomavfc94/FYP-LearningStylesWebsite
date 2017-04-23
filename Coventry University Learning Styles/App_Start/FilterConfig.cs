using System.Web;
using System.Web.Mvc;

namespace Coventry_University_Learning_Styles
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
