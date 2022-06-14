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
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.HasKey(f => f.Id);
            
            builder.HasMany(filme => filme.FilmeAtors)
                .WithOne(filmeAtor => filmeAtor.Filme)
                .HasForeignKey(filmeAtor => filmeAtor.FilmeId);

            builder.HasMany(filme => filme.PedidoFilmes)
                .WithOne(pedidoFilme => pedidoFilme.Filme)
                .HasForeignKey(pedidoFilme => pedidoFilme.FilmeId);
        }
    }
}
