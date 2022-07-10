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
    public class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(LocadoraContext context) : base(context)
        {
        }

        public Estado GetEstadoById(int Id)
        {
            var estado = new Estado();

            estado = _context.Estados
                                .Include("Cidades")
                                .Include("Cidades.Enderecos")
                                .Where(e => e.Id == Id)
                                .FirstOrDefault();
            return estado;
        }

        public List<Estado> GetEstados()
        {
            var estados = new List<Estado>();

            estados = _context.Estados
                                .Include(e => e.Cidades)
                                .Include("Cidades.Enderecos")
                                .ToList();
            return estados;
        }
    }
}
