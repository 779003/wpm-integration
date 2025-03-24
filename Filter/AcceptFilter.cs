using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Linq;
using System.Net.Http;

namespace WebApplication1.Filter
{
    public class AcceptFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // 1) URL 쿼리 파라미터 추출
            var query = actionContext.Request.RequestUri.ParseQueryString();
            var format = query["format"]?.ToLower();

            // 2) 만약 format=xml or json 값이 있으면 Accept 헤더를 강제 변경
            if (format == "xml")
            {
                actionContext.Request.Headers.Accept.Clear();
                actionContext.Request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            }
            else if (format == "json")
            {
                actionContext.Request.Headers.Accept.Clear();
                actionContext.Request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            base.OnActionExecuting(actionContext);
        }
    }
}