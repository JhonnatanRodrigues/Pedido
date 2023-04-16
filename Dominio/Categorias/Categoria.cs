using Pedido.Dominio.Padrao;

namespace Pedido.Dominio.Categorias
{
    public class Categoria : EntEmp
    {
        public string Tipo { get; set; }
        public string? Descricao { get;}
        public string? ImagemUri { get; set; }
    }
}