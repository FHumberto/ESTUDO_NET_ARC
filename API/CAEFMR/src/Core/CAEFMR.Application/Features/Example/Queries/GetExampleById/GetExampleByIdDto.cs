namespace CAEFMR.Application.Features.Example.Queries.GetExampleById;

public class GetExampleByIdDto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
