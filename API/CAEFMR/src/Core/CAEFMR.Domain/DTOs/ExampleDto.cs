using CAEFMR.Domain.Entities;

namespace CAEFMR.Domain.DTOs;

public class ExampleDto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public decimal Preco { get; set; }

    public ExampleDto() { }

    public ExampleDto(Example example)
    {
        Id = example.Id;
        Nome = example.Nome;
        Preco = example.Preco;
    }
}