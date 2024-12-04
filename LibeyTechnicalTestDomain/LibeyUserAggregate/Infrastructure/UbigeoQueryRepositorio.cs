using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class UbigeoQueryRepositorio : IUbigeoQueryRepositorio
    {
        private readonly Context _context;
        public UbigeoQueryRepositorio(Context context)
        {
            _context = context;
        }


        public List<UbigeoResponseDTO> ListUbigeo(string regionCode, string provinceCode)
        {
            var ubigeos = _context.Ubigeos
            .Where(p => p.RegionCode == regionCode && p.ProvinceCode== provinceCode)
            .Select(p => new UbigeoResponseDTO
            {
                UbigeoCode=p.UbigeoCode,
                ProvinceCode = p.ProvinceCode,
                RegionCode=p.RegionCode,
                UbigeoDescription = p.UbigeoDescription
            })
            .ToList();

            return ubigeos;
        }


    }
}



