using Exp.Core.Common.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace Exp.UI.WebAPI.Controllers
{
    [RoutePrefix("api/Dynamic")]
    public class DynamicController : ApiController
    {
        private readonly DynamicService testService = new DynamicService();
        
        // GET: api/Test
        public IEnumerable<dynamic> Get()
        {
            return testService.Get();
        }

        // GET: api/Test/5
        public dynamic Get(int id)
        {
            return testService.Get(id);
        }

        [Route("Named")]
        public object GetNamed()
        {
            object r = new { Items = testService.Get() };
            return r;
        }
    }
}