using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BlogSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Uygulama ba�lad��� an �al���r.Initializer s�n�f�n� burada tan�tmam�z gerek
            //Yada blogcontext i�inde bir yap�c� metot ile yapabiliriz.
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
