using Exp.Core.Common.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace Exp.UI.WebAPI.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        private readonly TestService testService = new TestService();
        
        // GET: api/Test
        public IEnumerable<dynamic> Get()
        {
            return testService.Get();
        }
        
        [Route("Named")]
        public object GetNamed()
        {
            object r = new { Items = testService.Get() };
            return r;
        }

        // GET: api/Test/5
        public dynamic Get(int id)
        {
            return testService.Get(id);
        }
    }
}