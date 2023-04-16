using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Categorias.Produtos;

namespace Pedido.Repositorio.Config.Categorias.Produtos

{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Tb_Produtos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdProduto")
                .IsRequired();

            builder.Property(p => p.NomeProduto)
                .HasColumnName("Produto")
                .IsRequired();

            builder.Property(P => P.Descricao)
                .HasColumnName("Descricao")
                .IsRequired();

            builder.Property(P => P.ImagemUri)
                .HasColumnName("Imagem");

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
