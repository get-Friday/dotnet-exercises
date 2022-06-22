using GeraEstoque.Repositories;
using GeraEstoque.Models;

namespace GeraEstoque.Screens;

class ListarProdutosScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {
        Console.WriteLine("LISTA DE PRODUTOS CADASTRADOS");
        Console.Write("");
        foreach (Produto produto in repository.Produtos)
        {
            Console.WriteLine(produto.ToString());
        }
        Console.ReadLine();
    }
}
