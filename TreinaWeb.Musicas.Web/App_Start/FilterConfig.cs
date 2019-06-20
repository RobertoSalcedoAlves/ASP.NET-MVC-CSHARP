using System.Web;
using System.Web.Mvc;
using TreinaWeb.Musicas.Web.Filtros;

namespace TreinaWeb.Musicas.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogActionFilter());
            filters.Add(new LogResultFilter());
        }
    }
}
