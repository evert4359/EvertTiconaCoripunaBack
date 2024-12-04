using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;



namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class UbigeoQuery: IUbigeoQuery
    {
        private readonly IUbigeoQueryRepositorio _repository;
        public UbigeoQuery(IUbigeoQueryRepositorio repository)
        {
            _repository = repository;
        }


        public List<UbigeoResponseDTO> ListUbigeo(string regionCode, string provinceCode)
        {
           var listUbigeos= _repository.ListUbigeo(regionCode, provinceCode);
            return listUbigeos;
        }
    }
}







