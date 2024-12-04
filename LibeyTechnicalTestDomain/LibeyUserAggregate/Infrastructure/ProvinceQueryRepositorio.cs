using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;


namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class ProvinceQueryRepositorio : IProvinceQueryRepositorio
    {

        private readonly Context _context;
        public ProvinceQueryRepositorio(Context context)
        {
            _context = context;
        }


        public List<ProvinceResponseDTO> ListProvince(string regionCode)
        {
            var provinces = _context.Provinces
             .Where(p => p.RegionCode == regionCode)
             .Select(p => new ProvinceResponseDTO
             {
                 ProvinceCode = p.ProvinceCode,
                 RegionCode=p.RegionCode,
                 ProvinceDescription = p.ProvinceDescription
             })
             .ToList();

            return provinces;
        }


    }

}
