using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;



namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class RegionQuery : IRegionQuery
    {
        private readonly IRegionQueryRepositorio _repository;


        public RegionQuery(IRegionQueryRepositorio repository)
        {
            _repository = repository;
        }


        public List<RegionResponseDTO> ListRegion()
        {
            var listRegion = _repository.ListRegion();
            return listRegion;
        }
    }
}


