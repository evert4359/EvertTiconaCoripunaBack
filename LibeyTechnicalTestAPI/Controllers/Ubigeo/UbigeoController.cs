using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.Ubigeo
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]")]


    public class UbigeoController : Controller
    {
        private readonly IUbigeoQueryRepositorio _queryUbigeo;

        public UbigeoController(IUbigeoQueryRepositorio queryUbigeo)
        {
            _queryUbigeo = queryUbigeo;
        }

        [HttpGet]
        [Route("listUbigeo")]
        public IActionResult listUbigeo(string regionCode, string provinceCode)
        {
            var list = _queryUbigeo.ListUbigeo(regionCode, provinceCode);
            return Ok(list);
        }

    }
}


