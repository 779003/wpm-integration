using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1
{
    public class WebApiApplication: System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // ����ڰ� "http://�����ּ�:��Ʈ/" (�� ��Ʈ URL)�� �������� ��
            // Swagger UI�� �ٷ� �����̷���
            if (HttpContext.Current.Request.Path == "/"
                || HttpContext.Current.Request.Path.Equals("", StringComparison.OrdinalIgnoreCase))
            {
                HttpContext.Current.Response.Redirect("~/swagger");
            }
        }
    }
}
