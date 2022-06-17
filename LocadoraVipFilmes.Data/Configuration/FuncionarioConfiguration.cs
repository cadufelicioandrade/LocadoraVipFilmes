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
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(f => f.Id);

            builder.HasMany(funcionario => funcionario.Pedidos)
                .WithOne(pedido => pedido.Funcionario)
                .HasForeignKey(pedido => pedido.FuncionarioId);

            builder.HasOne(funcionario => funcionario.Endereco)
                .WithOne(endereco => endereco.Funcionario)
                .HasForeignKey<Endereco>(endereco => endereco.FuncionarioId);

            builder.Property(f => f.SobreNome).HasMaxLength(35);

        }
    }
}
