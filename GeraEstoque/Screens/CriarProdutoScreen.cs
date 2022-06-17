namespace GeraEstoque.Screens;

class CriarProdutoScreen
{
    public static void Iniciar()
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