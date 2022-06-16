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
                case 0:
                    break;
                case 1:
                    CadastrarProduto();
                    break;
                case 2:
                case 3:
                case 4:
                    Iniciar();
                    break;
                default:
                    Console.Write("Opção inválida");
                    Iniciar();
                    break;
            }
        }
        static void CadastrarProduto()
        {
            Console.Clear();
            Console.Write("Insira o nome do produto: ");
            string product = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Sua quantidade em estoque: ");
            int qntStock = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Seu valor de compra: ");
            float price = float.Parse(Console.ReadLine());

            Guid obj = Guid.NewGuid();

            Console.WriteLine("");
            Console.Write(@$"Produto Cadastrado com sucesso!
            ID: {obj};
            Nome: {product};
            Qtd: {qntStock};
            R$ Compra: {price.ToString("C")};
            ");

        }
    }
}
