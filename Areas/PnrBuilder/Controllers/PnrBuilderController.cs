using System.Collections.Generic;
using System.Web.Http;

namespace WebApplication1.Areas.PnrBuild.Controllers
{

    [RoutePrefix("api/pnrBuilder")]
    public class PnrBuilderController : ApiController
    {
        // GET: PnrBuild/Default
        [HttpGet, Route("")]
        public IHttpActionResult Get(int id)
        {
            return Ok(new { success = true });
        }
    }
}