using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Cardapios.CardapioCategorias.CardapioCategoriaItens;

namespace Pedido.Repositorio.Config.Cardapios.CardapioCategorias.CardapioCategoriaItens
{
    public class CardapioCategoriaItemConfig : IEntityTypeConfiguration<CardapioCategoriaItem>
    {
        public void Configure(EntityTypeBuilder<CardapioCategoriaItem> builder)
        {
            builder.ToTable("Tb_Cardapio_Categoria_Itens");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdCardCategItem")
                .IsRequired();

            builder.Property(p => p.CodigoCardapioCategoria)
                .HasColumnName("IdCardCategoria")
                .IsRequired();

            builder.Property(P => P.CodigoItem)
                .HasColumnName("IdItem")
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
                .HasForeignKey(p => p.CodigoItem)
                .IsRequired();
        }
    }
}
