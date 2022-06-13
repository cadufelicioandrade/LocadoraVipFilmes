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
    public class PedidoFilmeConfiguration : IEntityTypeConfiguration<PedidoFilme>
    {
        public void Configure(EntityTypeBuilder<PedidoFilme> builder)
        {
            throw new NotImplementedException();
        }
    }
}
