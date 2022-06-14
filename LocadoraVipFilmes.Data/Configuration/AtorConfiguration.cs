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
    public class AtorConfiguration : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(ator => ator.FilmeAtors)
                .WithOne(filmeAtor => filmeAtor.Ator)
                .HasForeignKey(filmeAtor => filmeAtor.AtorId);
        }
    }
}
