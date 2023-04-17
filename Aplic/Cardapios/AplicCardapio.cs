using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;
using Pedido.Dominio.Categorias;
using Pedido.Dominio.Categorias.Produtos;
using Pedido.Dominio.ImageUploads;

namespace Pedido.Aplic.Cardapios
{
    public class AplicCardapio : IAplicCardapio
    {
        private readonly IRepCardapioCategoria _repCardapioCategoria;
        private readonly IRepCardapioCategoriaProdutos _repCardapioCategoriaProduto;
        private readonly IRepCategoria _repCategoria;
        private readonly IRepProduto _repProduto;

        public AplicCardapio(IRepCardapioCategoria repCardapioCategoria,
                             IRepCardapioCategoriaProdutos repCardapioCategoriaProdutos,
                             IRepCategoria repCategoria,
                             IRepProduto repProduto)
        {
            _repCardapioCategoria = repCardapioCategoria;
            _repCardapioCategoriaProduto = repCardapioCategoriaProdutos;
            _repCategoria = repCategoria;
            _repProduto = repProduto;
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
        public List<CardapioCategoriaProduto> ListarProdutosCategoria(int codigoCardapioCategoria)
        {
            return _repCardapioCategoriaProduto.Listar().Where(p => p.CodigoCardapioCategoria == codigoCardapioCategoria).Include(p => p.Produtos).Include(p => p.CardapioCategoria).ToList();
        }
        public void VincularImagem(ImageUploadDto dto, string uriImage)
        {
            switch (dto.UploadImagePara)
            {
                case EnumUploadImagePara.Categoria:
                    VincularImagem_Categoria(dto, uriImage);
                    break;
                case EnumUploadImagePara.Produto:
                    VincularImagem_Produto(dto, uriImage);
                    break;
                default:
                    throw new Exception($"Não foi possível vincular imagem.");
            }
        }

        private void VincularImagem_Categoria(ImageUploadDto dto, string uriImage)
        {
            var categoria = _repCategoria.Listar().FirstOrDefault(p => p.Id == dto.CodigoDestino);
            if (categoria == null)
                throw new Exception($"Categoria não encontrada.");

            categoria.ImagemUri = uriImage;

            _repCategoria.SaveChanges();
        }

        private void VincularImagem_Produto(ImageUploadDto dto, string uriImage)
        {
            var produto = _repProduto.Listar().FirstOrDefault(p => p.Id == dto.CodigoDestino);
            if (produto == null)
                throw new Exception($"Produto não encontrada.");

            produto.ImagemUri = uriImage;

            _repCategoria.SaveChanges();
        }
    }
}
