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

        public Filme GetFilme(int id)
        {
            var filme = new Filme();
            filme = _context.Filmes
                                .Include(f => f.Genero)
                                .Include(f => f.Produtora)
                                .Include(f => f.FilmeAtors)
                                .ThenInclude(f => f.Ator)
                            .Where(f => f.Id == id)
                            .FirstOrDefault();
            return filme;
        }

        public List<Filme> GetFilmes()
        {
            var filmes = new List<Filme>();
            filmes = _context.Filmes
                                .Include(f => f.Genero)
                                .Include(f => f.Produtora)
                                .Include(f => f.FilmeAtors)
                                .ThenInclude(f => f.Ator)
                            .ToList();

            return filmes;
        }
    }
}
