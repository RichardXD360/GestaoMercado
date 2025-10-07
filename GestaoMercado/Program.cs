// See https://aka.ms/new-console-template for more information

using GestaoMercado;
using GestaoMercado.Service;

int Main()
{
    MostrarMenu();
    
    
    return 0;
};

void MostrarMenu()
{
    Console.WriteLine(@"
********************************************
.....     Gerenciador Rich Market      .....
********************************************");

    string[] opcoes = ["1-Vender Produto", "2-Comprar Produto", "3-Estoque", "4-Gestao Financeira", "5-Adicionar Produto"];
    foreach (var opco in opcoes)
    {
        Console.WriteLine(opco);
    }

    Console.Write("\nResposta: ");
    string escolhaUser = Console.ReadLine();
    switch (escolhaUser)
    {
        case "1":
            VenderProduto();
            break;
        case "2":
            ComprarProduto();
            break;
        case "3":
            Estoque();
            break;
        case "4":
            
            break;
        case "5":
            AdicionarProduto();
            break;
    }
}

void Estoque()
{
    ProdutosBLL  produtosBLL = new ProdutosBLL();
    var produtos = produtosBLL.ListarProdutos();
    foreach (var produto in produtos)
    {
        Console.WriteLine($"Nome: {produto.Nome} - Custo: {produto.Custo} - Preço de venda: {produto.Preco} / QTD: {produto.Quantidade} ");
    }
    Console.ReadKey();
    MostrarMenu();
}

void AdicionarProduto()
{
    Console.WriteLine("Nome do produto: ");
    var nome = Console.ReadLine();
    Console.WriteLine("Custo do produto: ");
    var custo = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Preço de venda do produto: ");
    var preco = decimal.Parse(Console.ReadLine());
    ProdutoDTO produto = new ProdutoDTO(nome, 0, custo, preco);
    
    ProdutosBLL produtosBLL = new ProdutosBLL();
    Console.WriteLine(produtosBLL.CriarProduto(produto));
    Console.ReadKey();
    MostrarMenu();
}

void VenderProduto()
{
    ProdutosBLL  produtosBLL = new ProdutosBLL();
    var produtos = produtosBLL.ListarProdutos();
    Console.WriteLine("Lista de Produtos disponiveis para Venda: ");
    foreach (var produto in produtos)
    {
        Console.WriteLine($"Nome: {produto.Nome}");
    }
    string escolhaUser =  Console.ReadLine();
    Console.WriteLine("Qual será quantidade vendida?");
    int quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine(produtosBLL.VenderProduto(escolhaUser, quantidade));
    Console.ReadKey();
    MostrarMenu();
}

void ComprarProduto()
{
    ProdutosBLL  produtosBLL = new ProdutosBLL();
    var produtos = produtosBLL.ListarProdutos();
    Console.WriteLine("Lista de Produtos disponiveis para Compra: ");
    foreach (var produto in produtos)
    {
        Console.WriteLine($"Nome: {produto.Nome}");
    }
    string escolhaUser =  Console.ReadLine();
    Console.WriteLine("Qual será a quantidade comprada?");
    int quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine(produtosBLL.ComprarProduto(escolhaUser, quantidade));
    Console.ReadKey();
    MostrarMenu();
}
/*
void CriarGestao()
{
    ProdutoContext context =  new ProdutoContext();
    
    GestaoDTO gestao = new GestaoDTO();
    gestao.Saldo = 100;
    gestao.Gasto = 0;
    gestao.Lucro = 0;
    gestao.NumVendas = 0;
    gestao.NomeGestor = "Richard Reis";
    
    context.Gestao.Add(gestao);
    context.SaveChanges();
}
*/
//CriarGestao();
Main();

