using LocadoraVipFilmes.Data.Context;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Repository
{
    public class ProdutoraRepository : BaseRepository<Produtora>, IProdutoraRepository
    {
        public ProdutoraRepository(LocadoraContext context) : base(context)
        {
        }
    }
}
