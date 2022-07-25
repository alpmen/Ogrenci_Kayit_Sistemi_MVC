using System.Web;
using System.Web.Mvc;

namespace Ogrenci_Kayit_Sistemi_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
