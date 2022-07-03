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
    public class FilmeRepository : BaseRepository<Filme>, IFilmeRepository
    {
        public FilmeRepository(LocadoraContext context) : base(context)
        {
        }

        public void AddFilmeAtor(int filmeId, List<Ator> ators)
        {
            foreach (Ator ator in ators)
                _context.FilmeAtores.Add(new FilmeAtor() { AtorId = ator.Id, FilmeId = filmeId});

            _context.SaveChanges();
        }
    }
}
