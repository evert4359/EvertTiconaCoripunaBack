using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.Province
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]")]

    public class ProvinceController : Controller
    {
        private readonly IProvinceQueryRepositorio _queryProvince;

        public ProvinceController(IProvinceQueryRepositorio queryProvince)
        {
            _queryProvince = queryProvince;
        }

        [HttpGet]
        [Route("listProvince")]
        public IActionResult listProvince(string regionCode)
        {
            var list = _queryProvince.ListProvince(regionCode);
            return Ok(list);
        }

    }
}
