namespace CAEFMR.Application.Wrappers;

public enum ErrorCode : short
{
    ModelStateNotValid = 0, //! erro de validacao
    BadRequest = 1,
    NotFound = 2, //! não encontrado
    Conflict = 3, //! já existe
    Exception = 4, //! erro genérico
}
