using System.Collections.Generic;
using System.Web.Http;
using WebApplication1.Filter;
using WebApplication1.Models;

namespace WebApplication1.Areas.ResInfoCreate.Controllers
{

    [AcceptFilter]
    [RoutePrefix("api/resInfoCreate")]
    public class ResInfoCreateController: ApiController
    {


        // POST /api/resInfoCreate
        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] NgsCommon request)
        {
            // 처리 로직
            return Ok(request);
        }








        // GET /api/resInfoCreate
        [HttpGet]
        [Route("")]  // 파라미터 없는 경로
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /api/resInfoCreate/5
        [HttpGet]
        [Route("{id:int}")]  // 정수 id 경로
        public IHttpActionResult Get(int id)
        {
            return Ok(new { success = true });
        }

        // PUT /api/resInfoCreate/5
        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            // 처리 로직
            return Ok(new { message = "Put Success" });
        }

        // DELETE /api/resInfoCreate/5
        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            // 처리 로직
            return Ok(new { message = "Delete Success" });
        }
    }

}