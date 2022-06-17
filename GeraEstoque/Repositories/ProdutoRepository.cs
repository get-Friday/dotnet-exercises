using GeraEstoque.Models;
namespace GeraEstoque.Repositories
{
    class ProdutoRepository
    {
        public IList<Produto> Produtos;
        public ProdutoRepository(Produto produtos)
        {
            Produtos.Add(produtos);
        }
    }
}