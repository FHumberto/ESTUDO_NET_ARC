using CAEFMR.Application.Wrappers;
using CAEFMR.Domain.DTOs;
using MediatR;

namespace CAEFMR.Application.Features.Example.Queries.GetById;

//?  ENTRA ==> : <== VOLTA
public record GetExampleByIdQuery(int Id) : IRequest<BaseResponse<ExampleDto>>;