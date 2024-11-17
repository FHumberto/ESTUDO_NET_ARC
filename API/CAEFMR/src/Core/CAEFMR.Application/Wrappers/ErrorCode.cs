namespace CAEFMR.Application.Wrappers;

public enum ErrorCode : short
{
    ModelStateNotValid = 0, //! erro de validacao
    NotFound = 1, //! não encontrado
    Conflict = 2, //! já existe
    Unauthorized = 3, //! erro de autorização
    Exception = 4, //! erro genérico
}
