namespace GestaoMercado;

public class GestaoDTO
{
    public int Id { get; set; }
    public string NomeGestor { get; set; }
    public decimal Saldo { get; set; }
    public decimal Lucro { get; set; }
    public decimal Gasto { get; set; }
    public int NumVendas  { get; set; }
}