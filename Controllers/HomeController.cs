using System.Net.Mime;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController: Controller
    {
        
        /*[System.Web.Http.HttpGet]
        public ContentResult Index()
        {
            string dd = "<asdfad>ddd</asdfad>";
            return new ContentResult
            {
                Content = dd,
                //ContentEncoding = Encoding.UTF8,
                //ContentType = "text/xml",
                
            };
        }*/

        [System.Web.Http.HttpGet]
        public ContentResult Index()
        {
            string dd = "<asdfad>ddd</asdfad>";
            return Content(dd, "text/xml");
        }


        [System.Web.Http.HttpGet]
        public ContentResult test()
        {
            string dd = "<asdfad>test</asdfad>";
            return Content(dd, "text/xml");
        }
    }
}
