using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;


namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class ProvinceQuery : IProvinceQuery
    {
        private readonly IProvinceQueryRepositorio _repository;

        public ProvinceQuery(IProvinceQueryRepositorio repository)
        {
            _repository = repository;
        }


        public List<ProvinceResponseDTO> ListProvince(string regionCode)
        {
           var listProvince=_repository.ListProvince(regionCode);
            return listProvince;
        }

    }

}



