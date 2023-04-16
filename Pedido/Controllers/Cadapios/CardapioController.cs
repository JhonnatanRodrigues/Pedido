using ADM.Api.Mensageria;
using Microsoft.AspNetCore.Mvc;
using Pedido.Aplic.Cardapios;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using System.Web.Http.OData;

namespace Pedido.Controllers.Cadapios
{
    [ApiController]
    [Route("api/Parametro")]
    public class CardapioController
    {
        private readonly IAplicCardapio _aplicCardapio;

        public CardapioController(IAplicCardapio aplicCardapio)
        {
            _aplicCardapio = aplicCardapio;
        }

        [HttpGet]
        [Route("ListarCategorias")]
        [EnableQuery]
        public IQueryable<CardapioCategoria> Listar()
        {
            var ret = _aplicCardapio.Listar();

            return ret;
        }

        [HttpGet]
        [Route("ListarCategorias/{idCardapio}")]
        [EnableQuery]
        public ResponseHttps ListarCategorias([FromRoute]int idCardapio)
        {
            try
            {
                var ret = _aplicCardapio.ListarCategorias(idCardapio);

                return new ResponseHttps().RetSucesso(ret);
            }
            catch (Exception ex)
            {
                return new ResponseHttps().RetError(ex.Message);
            }
        }

        [HttpGet]
        [Route("ListarProdutosCategoria/{idCardapioCategoria}")]
        [EnableQuery]
        public ResponseHttps ListarProdutosCategoria([FromRoute] int idCardapioCategoria)
        {
            try
            {
                var ret = _aplicCardapio.ListarProdutosCategoria(idCardapioCategoria);

                return new ResponseHttps().RetSucesso(ret);
            }
            catch (Exception ex)
            {
                return new ResponseHttps().RetError(ex.Message);
            }
        }
    }
}