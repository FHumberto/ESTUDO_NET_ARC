using AutoMapper;
using CAEFMR.Application.Features.Example.Commands.Create;
using CAEFMR.Application.Features.Example.Commands.Update;
using CAEFMR.Application.Features.Example.Queries.GetById;
using CAEFMR.Application.Features.Example.Queries.GetList;
using CAEFMR.Domain.Entities;

namespace CAEFMR.Application.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        //? De -> Para
        CreateMap<Example, GetExampleByIdDto>();
        CreateMap<Example, GetExampleListDto>();
        CreateMap<CreateExampleCommand, Example>();
        CreateMap<UpdateExampleCommand, Example>();
    }
}