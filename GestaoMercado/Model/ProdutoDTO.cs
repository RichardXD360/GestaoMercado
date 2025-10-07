using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestaoMercado;

[Table("Produto")]
public class ProdutoDTO
{
    public ProdutoDTO(string  nome, int quantidade, decimal custo, decimal preco)
    {
        Nome = nome;
        Quantidade = quantidade;
        Custo = custo;
        Preco = preco;
    }
    
    [Key]
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Custo { get; set; }
    public decimal Preco { get; set; }

    public decimal RetornarLucro()
    {
        return  Preco - Custo;
    }
}