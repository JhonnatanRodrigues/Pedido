using Pedido.Dominio.Cardapios.CardapioCategorias;

namespace Pedido.Aplic.Cardapios
{
    public class AplicCardapio : IAplicCardapio
    {
        private readonly IRepCardapioCategoria _repCardapioCategoria;

        public AplicCardapio(IRepCardapioCategoria repCardapioCategoria)
        {
            _repCardapioCategoria = repCardapioCategoria;
        }

        public object ListarCategorias(int codigoCardapio)
        {
            return _repCardapioCategoria.Where(p => p.CodigoCategoria == codigoCardapio).ToList();
        }
    }
}
