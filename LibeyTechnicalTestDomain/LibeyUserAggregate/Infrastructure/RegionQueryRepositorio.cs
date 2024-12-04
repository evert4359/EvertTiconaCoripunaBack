using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;


namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class RegionQueryRepositorio: IRegionQueryRepositorio
    {
        private readonly Context _context;
        public RegionQueryRepositorio(Context context)
        {
            _context = context;
        }

        public List<RegionResponseDTO> ListRegion()
        {
            var regions = _context.Regions
           .Select(dt => new RegionResponseDTO
           {
               RegionCode = dt.RegionCode,
               RegionDescription = dt.RegionDescription
           })
           .ToList();
            return regions;
        }


    }
}



