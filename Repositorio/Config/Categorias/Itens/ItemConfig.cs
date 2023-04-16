using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Categorias.Itens;

namespace Pedido.Repositorio.Config.Categorias.Itens
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Tb_Itens");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdItem")
                .IsRequired();

            builder.Property(p => p.Produto)
                .HasColumnName("Produto")
                .IsRequired();

            builder.Property(P => P.Descricao)
                .HasColumnName("Descricao")
                .IsRequired();

            builder.Property(P => P.Preco)
                .HasColumnName("Preco")
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
