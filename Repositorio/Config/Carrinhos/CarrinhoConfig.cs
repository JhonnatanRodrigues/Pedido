using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Carrinhos;

namespace Pedido.Repositorio.Config.Carrinhos
{
    public class CarrinhoConfig : IEntityTypeConfiguration<Carrinho>
    {
        public void Configure(EntityTypeBuilder<Carrinho> builder)
        {
            builder.ToTable("Tb_Carrinhos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdCarrinho")
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnName("Status")
                .IsRequired();

            builder.Property(P => P.ValorTotal)
                .HasColumnName("ValorTotal")
                .IsRequired();
            
            builder.Property(P => P.CodigoEmpTablet)
                .HasColumnName("IdEmpTablet")
                .IsRequired();

            builder.Property(P => P.IdEmp)
                .HasColumnName("IdEmp")
                .IsRequired();
        }
    }
}
