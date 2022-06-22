using GeraEstoque.Screens;
using GeraEstoque.Repositories;

namespace GeraEstoque;

internal class Program
{
    static void Main(string[] args)
    {
        var repo = new ProdutoRepository();
        MenuScreen.Iniciar(repo);
    }
}
