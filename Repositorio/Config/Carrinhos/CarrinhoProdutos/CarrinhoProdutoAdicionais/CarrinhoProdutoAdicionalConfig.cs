using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais;

namespace Pedido.Repositorio.Config.Carrinhos.CarrinhoProdutos.CarrinhoProdutoAdicionais
{
    public class CarrinhoProdutoAdicionalConfig : IEntityTypeConfiguration<CarrinhoProdutoAdicional>
    {
        public void Configure(EntityTypeBuilder<CarrinhoProdutoAdicional> builder)
        {
            builder.ToTable("Tb_Carrinho_Produto_Adicional");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdCarrinhoProdutoAdicional")
                .IsRequired();

            builder.Property(p => p.CodigoCarrinhoProduto)
                .HasColumnName("IdCarrinhoProduto")
                .IsRequired();

            builder.Property(P => P.CodigoProdutoAdicional)
                .HasColumnName("IdProdutoAdicional")
                .IsRequired();

            builder.Property(P => P.IdEmp)
                .HasColumnName("IdEmp")
                .IsRequired();


            builder.HasOne(p => p.CarrinhoProduto)
                .WithMany()
                .HasForeignKey(p => p.CodigoCarrinhoProduto)
                .IsRequired();

            builder.HasOne(p => p.ProdutoAdicional)
                .WithMany()
                .HasForeignKey(p => p.CodigoProdutoAdicional)
                .IsRequired();
        }
    }
}
