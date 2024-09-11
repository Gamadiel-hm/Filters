using Filters.Filters;
using Filters.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ApiController]
    [Route("test")]
    [TypeFilter(typeof(ExeptionManagerFilter))]
    public class ExeptionTestController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            throw new MyException("fallo algo");
        }
    }
}
