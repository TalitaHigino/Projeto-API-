using ProjProduto.Models;

namespace Projproduto.Models
{
    public class Produto
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}