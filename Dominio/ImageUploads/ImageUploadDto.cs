namespace Pedido.Dominio.ImageUploads
{
    public class ImageUploadDto
    {
        public string Base64Image { get; set; }
        public EnumUploadImagePara UploadImagePara { get; set; }
        public int CodigoDestino { get; set; }
    }

    public enum EnumUploadImagePara
    {
        Categoria = 0,
        Produto = 1
    }
}
