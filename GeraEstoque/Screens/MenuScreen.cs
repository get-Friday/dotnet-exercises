namespace GeraEstoque.Screens
{
    class MenuScreen
    {
        public static void Iniciar()
        {
            string textoMenu = @"Seja bem vindo ao GeraEstoque 1.0
----------------------------------------
1  Cadastrar produto
2  Consultar produto
3  Modificar produto
4  Excluir produto
0  Sair
Digite a opção: ";
            Console.Clear();
            Console.Write(textoMenu);
            var option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CriarProdutoScreen.Iniciar(); Iniciar(); break;
                default:
                    Environment.Exit(0); break;
            }
        }
    }
}