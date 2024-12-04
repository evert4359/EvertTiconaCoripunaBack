using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IUbigeoQueryRepositorio
    {
        List<UbigeoResponseDTO> ListUbigeo(string regionCode,string provinceCode);
    }
}




