using GeraEstoque.Repositories;

namespace GeraEstoque.Screens;

class MenuScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {
        string textoMenu = @"Seja bem vindo ao GeraEstoque 1.0
----------------------------------------
1  Cadastrar produto
2  Consultar produto
3  Modificar produto
4  Excluir produto
5  Listar todos os produtos
0  Sair
Digite a opção: ";
        Console.Clear();
        Console.Write(textoMenu);
        var option = byte.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CriarProdutoScreen.Iniciar(repository); Iniciar(repository); break;
            case 5:
                ListarProdutosScreen.Iniciar(repository); Iniciar(repository); break;
            default:
                Environment.Exit(0); break;
        }
    }
}

