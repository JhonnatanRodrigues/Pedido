using ADM.Api.Mensageria;
using Microsoft.AspNetCore.Mvc;
using Pedido.Aplic.Pedidos.Carrinhos;
using System.Web.Http.OData;

namespace Pedido.Controllers.Pedidos.Carrinhos
{
    [ApiController]
    [Route("api/Carrinho")]
    public class CarrinhoController
    {
        private readonly IAplicCarrinho _aplicCarrinho;

        public CarrinhoController(IAplicCarrinho aplicCarrinho)
        {
            _aplicCarrinho = aplicCarrinho;
        }


        [HttpGet]
        [Route("ListarProdutosCarrinho/{idCarrinho}")]
        [EnableQuery]
        public ResponseHttps ListarProdutosCarrinho([FromRoute] int idCarrinho)
        {
            try
            {
                var ret = _aplicCarrinho.ListarProdutosCarrinho(idCarrinho);

                return new ResponseHttps().RetSucesso(ret);
            }
            catch (Exception ex)
            {
                return new ResponseHttps().RetError(ex.Message);
            }
        }

        [HttpGet]
        [Route("ListarProdutoCarrinho/{idProdutoCarrinho}")]
        [EnableQuery]
        public ResponseHttps ListarProdutoCarrinho([FromRoute] int idProdutoCarrinho)
        {
            try
            {
                var ret = _aplicCarrinho.ListarCarrinhoProduto(idProdutoCarrinho);

                return new ResponseHttps().RetSucesso(ret);
            }
            catch (Exception ex)
            {
                return new ResponseHttps().RetError(ex.Message);
            }
        }
    }
}