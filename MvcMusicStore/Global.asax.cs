using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Data.Entity;

namespace MvcMusicStore
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(
            new MvcMusicStore.Models.SampleData());
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}