using System.Web.Http;

namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 구성 및 서비스

            // Web API 경로
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // XML을 기본 포맷터로 설정
            var xml = config.Formatters.XmlFormatter;
            xml.UseXmlSerializer = true;

            config.Formatters.Remove(xml);
            config.Formatters.Insert(0, xml);  // XML을 첫 번째(최우선)로

            // (선택) JSON 포맷터를 제거한다면, 응답은 오직 XML만 가능
            //formatters.Remove(formatters.JsonFormatter);
        }
    }
}
