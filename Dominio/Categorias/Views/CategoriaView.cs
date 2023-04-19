namespace Pedido.Dominio.Categorias.Views
{
    public class CategoriaView
    {
        public int CodigoCategoria { get; private set; }
        public string Tipo { get; private set; }
        public string? Descricao { get; private set; }
        public string? ImagemUri { get; private set; }

        public CategoriaView NovoView(Categoria categoria)
        {
            if (categoria == null)
                return new CategoriaView();

            return new CategoriaView
            {
                CodigoCategoria = categoria.Id,
                Tipo = categoria.Tipo,
                Descricao = categoria.Descricao,
                ImagemUri = categoria.ImagemUri
            };
        }
    }
}
