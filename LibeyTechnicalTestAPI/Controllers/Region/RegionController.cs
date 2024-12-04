using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.Region
{
 
    /// [Route("api/[controller]")] 
    [ApiController]
    [Route("[controller]")]
    public class RegionController : ControllerBase
    {

        private readonly IRegionQueryRepositorio _queryRegion;

        public RegionController(IRegionQueryRepositorio queryRegion)
        {
            _queryRegion = queryRegion;
        }

        [HttpGet]
        [Route("listRegion")]
        public IActionResult listRegion()
        {
            var list = _queryRegion.ListRegion();
            return Ok(list);
        }

    }
}
