using System.Web;
using System.Web.Mvc;

namespace TesteListagemDeUsuarios.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
