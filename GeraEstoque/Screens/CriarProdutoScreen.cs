using GeraEstoque.Repositories;
using GeraEstoque.Models;

namespace GeraEstoque.Screens;

class CriarProdutoScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {
        Console.Clear();
        Console.Write("Insira o nome do produto: ");
        string nome = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Sua quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Seu valor de compra: ");
        decimal custo = decimal.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Seu valor de venda: ");
        decimal venda = decimal.Parse(Console.ReadLine());

        Guid obj = Guid.NewGuid();

        Produto produto = new Produto(nome!, quantidade, custo, venda);

        Console.WriteLine("");
        Console.WriteLine("Produto adicionado!");
        repository.Produtos.Add(produto);

    }
}
