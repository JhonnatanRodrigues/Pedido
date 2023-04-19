using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos.Views;

namespace Pedido.Aplic.Pedidos.Carrinhos
{
    public class AplicCarrinho : IAplicCarrinho
    {
        private readonly IRepCarrinhoProduto _repCarrinhoProduto;

        public AplicCarrinho(IRepCarrinhoProduto repCarrinhoProduto)
        {
            _repCarrinhoProduto = repCarrinhoProduto;
        }

        public List<CarrinhoProdutosAgrupadoView> ListarProdutosCarrinho(int codigoCarrinho)
        {
            var ret = new List<CarrinhoProdutosAgrupadoView>();

            var carrinhoProdutos = _repCarrinhoProduto.Listar().Where(p => p.CodigoCarrinho == codigoCarrinho).Include(p => p.Produto).ToList();

            foreach (var carrinhoProduto in carrinhoProdutos)
            {
                if (carrinhoProduto.Produto == null)
                    continue;

                ret.Add(new CarrinhoProdutosAgrupadoView().NovoView(carrinhoProduto));
            }

            return ret;
        }
        public List<CarrinhoProdutoView> ListarCarrinhoProduto(int codigoProdutoCarrinho)
        {
            var ret = new List<CarrinhoProdutoView>();

            var carrinhoProdutos = _repCarrinhoProduto.Listar()
                                        .Where(p => p.Id == codigoProdutoCarrinho)
                                        .Include(p => p.Produto)
                                        .Include(p => p.CarrinhoProdutoAdicionais)
                                            .ThenInclude(p => p.ProdutoAdicional)
                                                .ThenInclude(p => p.Adicional)
                                        .ToList();

            foreach (var carrinhoProduto in carrinhoProdutos)
            {
                ret.Add(new CarrinhoProdutoView().NovoView(carrinhoProduto));
            }

            return ret;
        }
    }
}
