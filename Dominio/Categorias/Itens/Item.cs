using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Categorias.Itens
{
    public class Item : EntEmp
    {
        public string Produto { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int CodigoCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}
