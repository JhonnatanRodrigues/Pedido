using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pedido.Dominio.Cardapios.CardapioCategorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Dominio.Categorias;

namespace Pedido.Repositorio.Config.Categorias
{
    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Tb_Categorias");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("IdCategoria")
                .IsRequired();

            builder.Property(p => p.Tipo)
                .HasColumnName("Tipo")
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
