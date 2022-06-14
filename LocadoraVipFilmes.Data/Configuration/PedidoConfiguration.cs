using LocadoraVipFilmes.Dominio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Configuration
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(pedido => pedido.PedidoFilmes)
                .WithOne(pedidoFilme => pedidoFilme.Pedido)
                .HasForeignKey(pedidoFilme => pedidoFilme.PedidoId);
        }
    }
}
