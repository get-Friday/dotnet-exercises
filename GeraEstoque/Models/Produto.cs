namespace GeraEstoque.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Custo { get; set; }
        public decimal Venda { get; set; }
        public Produto()
        {

        }
        public Produto(string nome, int quantidade, decimal custo, decimal venda)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Quantidade = quantidade;
            Custo = custo;
            Venda = venda;
        }
    }
}