using LocadoraVipFilmes.Data.Context;
using LocadoraVipFilmes.Data.Interfaces;
using LocadoraVipFilmes.Dominio.Model;
using Microsoft.EntityFrameworkCore;
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

        public List<Ator> GetAtoresFilmes(int? id = null)
        {
            var list = new List<Ator>();

            if (id.HasValue)
                list = _context.Atores
                                    .Include(a => a.FilmeAtors)
                                    .ThenInclude(fa => fa.Filme)
                                    .Where(a => a.Id == id.Value)
                                    .ToList();
            else
                list = _context.Atores
                                    .Include(a => a.FilmeAtors)
                                    .ThenInclude(fa => fa.Filme)
                                    .ToList();

            return list;
        }
    }
}
