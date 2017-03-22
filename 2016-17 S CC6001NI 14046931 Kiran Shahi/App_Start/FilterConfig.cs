using System.Web;
using System.Web.Mvc;

namespace _2016_17_S_CC6001NI_14046931_Kiran_Shahi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
