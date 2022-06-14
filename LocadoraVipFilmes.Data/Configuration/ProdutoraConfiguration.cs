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
    public class ProdutoraConfiguration : IEntityTypeConfiguration<Produtora>
    {
        public void Configure(EntityTypeBuilder<Produtora> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(produtora => produtora.Filmes)
                .WithOne(filme => filme.Produtora)
                .HasForeignKey(filme => filme.ProdutoraId); 
        }
    }
}
