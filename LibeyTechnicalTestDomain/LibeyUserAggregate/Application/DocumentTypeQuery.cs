using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class DocumentTypeQuery : IDocumentTypeQuery
    {
        private readonly IDocumentTypeQueryRepositorio _repository;

        public DocumentTypeQuery(IDocumentTypeQueryRepositorio repository)
        {
            _repository = repository;
        }


        public List<DocumentTypeResponseDTO> ListDocumentType()
        {
            var listDocType= _repository.ListDocumentType();
            return listDocType;
        }


    }
}


