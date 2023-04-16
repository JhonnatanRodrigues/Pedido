using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaItens;

namespace Pedido.Aplic.Cardapios
{
    public class AplicCardapio : IAplicCardapio
    {
        private readonly IRepCardapioCategoria _repCardapioCategoria;
        private readonly IRepCardapioCategoriaItem _repCardapioCategoriaItem;

        public AplicCardapio(IRepCardapioCategoria repCardapioCategoria)
        {
            _repCardapioCategoria = repCardapioCategoria;
        }

        public IQueryable<CardapioCategoria>? Listar()
        {
            return _repCardapioCategoria.Listar().Include(p => p.Categoria);
        }
        public List<CardapioCategoria> ListarCategorias(int codigoCardapio)
        {
            var ret = _repCardapioCategoria.Listar().Where(p => p.CodigoCardapio == codigoCardapio).Include(p => p.Categoria).ToList();

            if (ret == null)
                throw new Exception($"Não foi encontrado nem uma categoria para o cardapio código: '{codigoCardapio}'.");

            return ret;
        }
        public List<CardapioCategoriaItem> ListarProdutosCategoria(int codigoCardapioCategoria)
        {
            return _repCardapioCategoriaItem.Listar().Where(p => p.CodigoCardapioCategoria == codigoCardapioCategoria).Include(p => p.Produtos).ToList();
        }
    }
}
