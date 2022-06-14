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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(cliente => cliente.Pedidos)
                .WithOne(pedido => pedido.Cliente)
                .HasForeignKey(pedido => pedido.ClienteId);

            builder.HasOne(cliente => cliente.Endereco)
                .WithOne(endereco => endereco.Cliente)
                .HasForeignKey<Endereco>(endereco => endereco.ClienteId);

        }
    }
}
