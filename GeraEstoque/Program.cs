namespace GeraEstoque
{
    internal class Program
    {
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
            Console.Clear();
            Console.Write(textoMenu);
            var option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: CadastrarProduto(); break;
            }
        }
    }
}