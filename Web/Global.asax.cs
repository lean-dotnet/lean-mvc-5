using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Web.App_Start;

namespace Web
{
  public class Global : System.Web.HttpApplication
  {

    protected void Application_Start(object sender, EventArgs e)
    {
      ViewEngines.Engines.Clear();
      ViewEngines.Engines.Add(new RazorViewEngine()
        {
          ViewLocationFormats = new string[] { },
          AreaViewLocationFormats = new string[] { "~/Areas/{2}/Views/{1}/{0}.cshtml", }
        }
      );

      AreaRegistration.RegisterAllAreas();
      Routing.RegisterRoutes(RouteTable.Routes);
    }

    protected void Session_Start(object sender, EventArgs e)
    {

    }

    protected void Application_BeginRequest(object sender, EventArgs e)
    {

    }

    protected void Application_AuthenticateRequest(object sender, EventArgs e)
    {

    }

    protected void Application_Error(object sender, EventArgs e)
    {

    }

    protected void Session_End(object sender, EventArgs e)
    {

    }

    protected void Application_End(object sender, EventArgs e)
    {

    }
  }
}
