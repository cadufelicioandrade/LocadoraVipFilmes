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

        public Ator GetAtoresFilmes(int id)
        {
            var ator = new Ator();

            ator = _context.Atores
                            .Include(a => a.FilmeAtors)
                            .Include("FilmeAtors.Filme")
                            .Include("FilmeAtors.Filme.Genero")
                            .Include("FilmeAtors.Filme.Produtora")
                            .FirstOrDefault();

            return ator;
        }

        public List<Ator> GetAllAtoresFilmes()
        {
            var list = new List<Ator>();

            list = _context.Atores
                            .Include(a => a.FilmeAtors)
                            .Include("FilmeAtors.Filme")
                            .Include("FilmeAtors.Filme.Genero")
                            .Include("FilmeAtors.Filme.Produtora")
                            .ToList();

            return list;

        }

    }
}
