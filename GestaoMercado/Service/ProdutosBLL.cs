namespace GestaoMercado.Service;

public class ProdutosBLL
{
    
    public string CriarProduto(ProdutoDTO produto)
    {
        if (produto == null || string.IsNullOrWhiteSpace(produto.Nome) || produto.Preco < 1 || produto.Preco > 100 || produto.Quantidade < 0 || produto.Quantidade > 100)
        {
            return "informações inválidas.";
        }

        ProdutoContext context = new ProdutoContext();
        context.Add(produto);
        context.SaveChanges();
        
        return "Produto cadastrado com sucesso";
    }

    public List<ProdutoDTO> ListarProdutos()
    {
        using var context = new ProdutoContext();
        return context.Produtos.ToList();
    }
    
    public string VenderProduto(string nomeProduto, int quantidade)
    {
        using var context = new ProdutoContext();
        var produtos = context.Produtos.ToList();
        
        var produto = produtos
            .Where(x => x.Nome == nomeProduto)
            .FirstOrDefault();
        
        var valorProdutos =  produto.Preco * quantidade;
        if (produto.Quantidade <= 0)
        {
            return "Esse produto não está no estoque";
        }
        var gestao = context.Gestao.FirstOrDefault(x => x.Id == 1);
        
        gestao.Lucro += produto.RetornarLucro() * quantidade;
        gestao.Saldo += valorProdutos;
        gestao.NumVendas += quantidade;
        
        produto.Quantidade -= quantidade;
        
        context.SaveChanges();
        return "Produto Vendido com sucesso";
    }
    public string ComprarProduto(string nomeProduto, int quantidade)
    {
        using var context = new ProdutoContext();
        var produtos = context.Produtos.ToList();
        var produto = produtos
            .Where(x => x.Nome == nomeProduto)
            .FirstOrDefault();
        
        var custoGeral = produto.Custo * quantidade;
        
        var gestao = context.Gestao.FirstOrDefault(x => x.Id == 1);

        if (gestao.Saldo < custoGeral)
        {
            return "Não há saldo suficiente para efetuar a compra desse produto";
        }
        
        gestao.Gasto += custoGeral;
        gestao.Saldo -= custoGeral;
        gestao.NumVendas += quantidade;
        produto.Quantidade += quantidade;
        
        context.SaveChanges();
        return "Produto Comprado com sucesso";
    }
}