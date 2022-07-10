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
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(LocadoraContext context) : base(context)
        {
        }

        public List<Cliente> GetClientes()
        {
            var list = new List<Cliente>();
            list = _context.Clientes
                            .Include(c => c.Endereco)
                            .Include(c => c.Pedidos)
                            .ToList();
            return list;
        }

        public Cliente GetClienteById(int id)
        {
            var cliente = new Cliente();

            cliente = _context.Clientes
                            .Include(c => c.Endereco)
                            .Include(c => c.Pedidos)
                            .FirstOrDefault();
            return cliente;
        }
    }
}
