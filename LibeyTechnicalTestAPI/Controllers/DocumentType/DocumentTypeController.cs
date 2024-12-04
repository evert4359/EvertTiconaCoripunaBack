using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTestAPI.Controllers.DocumentType
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]")]
    public class DocumentTypeController : Controller
    {
        private readonly IDocumentTypeQueryRepositorio _queryDocType;

        public DocumentTypeController(IDocumentTypeQueryRepositorio queryDocType)
        {
            _queryDocType = queryDocType;
        }

        [HttpGet]
        [Route("listDocumentType")]
        public IActionResult listDocumentType()
        {
            var list = _queryDocType.ListDocumentType();
            return Ok(list);
        }

    }
}
