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
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(LocadoraContext context) : base(context)
        {
        }

        public List<Cidade> GetCidades()
        {
            var cidades = new List<Cidade>();

            cidades = _context.Cidades
                                .Include(c => c.Estado)
                                .Include(c => c.Enderecos)
                                .ToList();

            return cidades;
        }

        public Cidade GetCidadeById(int id)
        {
            var cidade = new Cidade();

            cidade = _context.Cidades
                                .Include(c => c.Estado)
                                .Include(c => c.Enderecos)
                                .FirstOrDefault();

            return cidade;
        }
    }
}
