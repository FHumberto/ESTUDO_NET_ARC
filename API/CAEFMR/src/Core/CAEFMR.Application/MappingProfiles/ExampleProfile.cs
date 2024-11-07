using AutoMapper;
using CAEFMR.Application.Features.Example.Commands.Create;
using CAEFMR.Application.Features.Example.Commands.Update;
using CAEFMR.Domain.DTOs;
using CAEFMR.Domain.Entities;

namespace CAEFMR.Application.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        //? De -> Para
        CreateMap<Example, ExampleDto>();
        CreateMap<Example, ExampleDto>();
        CreateMap<Example, ExampleDto>();
        CreateMap<CreateExampleCommand, Example>();
        CreateMap<UpdateExampleCommand, Example>();
    }
}