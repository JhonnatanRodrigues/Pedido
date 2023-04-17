using ADM.Api.Mensageria;
using Microsoft.AspNetCore.Mvc;
using Pedido.Aplic.Cardapios;
using Pedido.Dominio.ImageUploads;
using Pedido.Infra.ImageUploads;

namespace Pedido.Controllers.ImageUploads
{
    [ApiController]
    [Route("api/ImageUpload")]
    public class ImageUploadController
    {
        private readonly IAplicCardapio _aplicCardapio;

        public ImageUploadController(IAplicCardapio aplicCardapio)
        {
            _aplicCardapio = aplicCardapio;
        }

        [HttpPost]
        [Route("UploadImage")]
        public ResponseHttps UploadImage([FromBody] ImageUploadDto dto)
        {
            try
            {
                var uriImage = new ImageUpload().UploadBase64Image(dto.Base64Image);

                _aplicCardapio.VincularImagem(dto, uriImage);

                return new ResponseHttps().RetSucesso();
            }
            catch (Exception ex)
            {
                return new ResponseHttps().RetError(ex.Message);
            }
        }
    }
}
