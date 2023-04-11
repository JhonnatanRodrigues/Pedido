using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Cardapios.CardapioCategorias;

namespace Pedido.Repositorio.Config.Cardapios.CardapioCategorias
{
    public class CardapioCategoriaConfig : IEntityTypeConfiguration<CardapioCategoria>
    {
        public void Configure(EntityTypeBuilder<CardapioCategoria> builder)
        {
            builder.ToTable("Tb_Cardapio_Categorias");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdCardCategoria")
                .IsRequired();

            builder.Property(p => p.CodigoCardapio)
                .HasColumnName("IdCardapio")
                .IsRequired();

            builder.Property(P => P.CodigoCategoria)
                .HasColumnName("IdCategoria")
                .IsRequired();

            builder.Property(P => P.IdEmp)
                .HasColumnName("IdEmp")
                .IsRequired();


            builder.HasOne(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.CodigoCategoria)
                .IsRequired();
        }
    }
}