using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Carrinhos.CarrinhoProdutos;

namespace Pedido.Repositorio.Config.Carrinhos.CarrinhoProdutos
{
    public class CarrinhoProdutoConfig : IEntityTypeConfiguration<CarrinhoProduto>
    {
        public void Configure(EntityTypeBuilder<CarrinhoProduto> builder)
        {
            builder.ToTable("Tb_Carrinho_Produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdCarrinhoProduto")
                .IsRequired();

            builder.Property(p => p.Observacao)
                .HasColumnName("Observacao");

            builder.Property(P => P.EntregarJuntoAoPedido)
                .HasColumnName("EntregarJuntoAoPedido")
                .IsRequired();
            
            builder.Property(P => P.ValorTotal)
                .HasColumnName("ValorTotal")
                .IsRequired();
            
            builder.Property(P => P.CodigoProduto)
                .HasColumnName("IdProduto")
                .IsRequired();
            
            builder.Property(P => P.CodigoCarrinho)
                .HasColumnName("IdCarrinho")
                .IsRequired();

            builder.Property(P => P.IdEmp)
                .HasColumnName("IdEmp")
                .IsRequired();


            builder.HasOne(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.CodigoProduto)
                .IsRequired();

            builder.HasOne(p => p.Carrinho)
                .WithMany()
                .HasForeignKey(p => p.CodigoCarrinho)
                .IsRequired();
        }
    }
}
