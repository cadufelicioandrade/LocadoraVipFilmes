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
    public class AtorRepository : BaseRepository<Ator>, IAtorRepository
    {
        public AtorRepository(LocadoraContext context) : base(context)
        {
        }
    }
}
