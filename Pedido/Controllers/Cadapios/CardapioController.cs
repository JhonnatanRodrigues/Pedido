using ADM.Api.Mensageria;
using Microsoft.AspNetCore.Mvc;
using Pedido.Aplic.Cardapios;

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
        [Route("ListarCategorias/{codigoCardapio}")]
        public ResponseHttps ListarCategorias([FromRoute]int codigoCardapio)
        {
            try
            {
                var ret = _aplicCardapio.ListarCategorias(codigoCardapio);

                return new ResponseHttps().RetSucesso(ret);
            }
            catch (Exception ex)
            {
                return new ResponseHttps().RetError(ex.Message);
            }
        }
    }
}
