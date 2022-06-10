namespace GeraEstoque
{
    internal class Program
    {
        public string[] products; 
        static void CadastrarProduto()
        {
            Console.Clear();
            Console.Write("Insira o produto: ");
            var product = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string textoMenu = @"Seja bem vindo ao GeraEstoque 1.0
----------------------------------------
1  Cadastrar produto
2  Consultar produto
3  Modificar produto
4  Excluir produto
0  Sair
Digite a opção: ";
            Console.Write(textoMenu);
            var option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: CadastrarProduto(); break;
            }
        }
    }
}