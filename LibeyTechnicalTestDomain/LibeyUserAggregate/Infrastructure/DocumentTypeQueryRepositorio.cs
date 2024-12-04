using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class DocumentTypeQueryRepositorio: IDocumentTypeQueryRepositorio
    {
        private readonly Context _context;

        public DocumentTypeQueryRepositorio(Context context)
        {
            _context = context;
        }
        public List<DocumentTypeResponseDTO> ListDocumentType()
        {
            var documentTypes = _context.DocumentTypes
            .Select(dt => new DocumentTypeResponseDTO
            {
                DocumentTypeId = dt.DocumentTypeId,
                DocumentTypeDescription = dt.DocumentTypeDescription
            })
            .ToList();
            return documentTypes;
        }

    }
}



