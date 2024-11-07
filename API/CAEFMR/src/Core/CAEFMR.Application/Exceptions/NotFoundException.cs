namespace CAEFMR.Application.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string name, object key) : base($"O elemento {name} ({key}) não encontrado")
    {

    }
}