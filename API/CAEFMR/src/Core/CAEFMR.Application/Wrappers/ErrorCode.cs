namespace CAEFMR.Application.Wrappers;

public enum ErrorCode : short
{
    ModelStateNotValid = 0, //! erro de validacao
    NotFound = 1, //! não encontrado
    Conflict = 2, //! já existe
    AccessDenied = 3, //! erro de autorização
    ErrorInIdentity = 4, //! erro de identidade
    Exception = 5, //! erro genérico
}
