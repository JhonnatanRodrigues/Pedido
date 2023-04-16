using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaProdutos;

namespace Pedido.Repositorio.Config.Cardapios.CardapioCategorias.CardapioCategoriaProdutos
{
    public class CardapioCategoriaProdutoConfig : IEntityTypeConfiguration<CardapioCategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CardapioCategoriaProduto> builder)
        {
            builder.ToTable("Tb_Cardapio_Categoria_Produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdCardCategProduto")
                .IsRequired();

            builder.Property(p => p.CodigoCardapioCategoria)
                .HasColumnName("IdCardCategoria")
                .IsRequired();

            builder.Property(P => P.CodigoProduto)
                .HasColumnName("IdProduto")
                .IsRequired();

            builder.Property(P => P.IdEmp)
                .HasColumnName("IdEmp")
                .IsRequired();


            builder.HasOne(p => p.CardapioCategoria)
                .WithMany()
                .HasForeignKey(p => p.CodigoCardapioCategoria)
                .IsRequired();

            builder.HasOne(p => p.Produtos)
                .WithMany()
                .HasForeignKey(p => p.CodigoProduto)
                .IsRequired();
        }
    }
}
