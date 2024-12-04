using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IUbigeoQuery
    {
        List<UbigeoResponseDTO> ListUbigeo(string regionCode, string provinceCode);
    }
}


