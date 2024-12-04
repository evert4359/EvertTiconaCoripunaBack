﻿using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.EFCore.Configuration
{
    public class RegionConfiguration: IEntityTypeConfiguration<Region>
    {

        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Region").HasKey(x => x.RegionCode);
        }
    }
}



