using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Categorias.Produtos.ProdutoAdicionais;

namespace Pedido.Repositorio.Config.Categorias.Produtos.ProdutoAdicionais
{
    public class ProdutoAdicionalConfig : IEntityTypeConfiguration<ProdutoAdicional>
    {
        public void Configure(EntityTypeBuilder<ProdutoAdicional> builder)
        {
            builder.ToTable("Tb_Produto_Adicionais");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdProdutoAdicional")
                .IsRequired();

            builder.Property(p => p.CodigoProduto)
                .HasColumnName("IdProduto")
                .IsRequired();

            builder.Property(P => P.CodigoAdicional)
                .HasColumnName("IdAdicional")
                .IsRequired();

            builder.Property(P => P.IdEmp)
                .HasColumnName("IdEmp")
                .IsRequired();


            builder.HasOne(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.CodigoProduto)
                .IsRequired();
            
            builder.HasOne(p => p.Adicional)
                .WithMany()
                .HasForeignKey(p => p.CodigoAdicional)
                .IsRequired();
        }
    }
}
