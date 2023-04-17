using Azure.Storage.Blobs;
using System.Text.RegularExpressions;

namespace Pedido.Infra.ImageUploads
{
    public class ImageUpload
    {
        private string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=sistemarestsa;AccountKey=+i93uaa7bRL0tKnD0Du1dba3avL5Qj56EHt8iVNbXpuYNEv427U5wbDI1tyCw+dsmfOgPhIzIw/k+AStExxifQ==;EndpointSuffix=core.windows.net";
        private string Container = "desenv";

        public string UploadBase64Image(string base64Image)
        {
            var nomeArquivo = Guid.NewGuid().ToString() +".jpg";

            var data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(base64Image, "");

            byte[] imageBytes = Convert.FromBase64String(data);

            var blobClient = new BlobClient(ConnectionString, Container, nomeArquivo);

            using(var stream = new MemoryStream(imageBytes))
            {
                blobClient.Upload(stream);
            }

            return blobClient.Uri.AbsoluteUri;
        }
    }
}
