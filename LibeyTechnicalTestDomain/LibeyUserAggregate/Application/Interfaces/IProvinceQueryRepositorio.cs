﻿using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;



namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IProvinceQueryRepositorio
    {
        List<ProvinceResponseDTO> ListProvince(string regionCode);
    }

}

