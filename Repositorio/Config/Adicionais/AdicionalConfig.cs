using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Dominio.Adicionais;

namespace Pedido.Repositorio.Config.Adicionais
{
    public class AdicionalConfig : IEntityTypeConfiguration<Adicional>
    {
        public void Configure(EntityTypeBuilder<Adicional> builder)
        {
            builder.ToTable("TB_Adicionais");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdAdicional")
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .IsRequired();

            builder.Property(P => P.Descricao)
                .HasColumnName("Descricao")
                .IsRequired();

            builder.Property(P => P.IdEmp)
                .HasColumnName("IdEmp")
                .IsRequired();
        }
    }
}
