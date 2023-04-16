using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Categorias.Produtos
{
    public class Produto : EntEmp
    {
        public string NomeProduto { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUri { get; set; }
        public decimal Preco { get; set; }
        public int CodigoCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}
