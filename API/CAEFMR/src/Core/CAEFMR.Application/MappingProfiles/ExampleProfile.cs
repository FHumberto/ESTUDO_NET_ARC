using AutoMapper;
using CAEFMR.Application.Features.Example.Queries.GetExampleById;
using CAEFMR.Application.Features.Example.Queries.GetExamplesList;
using CAEFMR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEFMR.Application.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<Example, GetExampleByIdDto>();
        CreateMap<Example, GetExampleListDto>();
    }
}