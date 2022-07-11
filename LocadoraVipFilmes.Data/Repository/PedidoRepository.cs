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
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(LocadoraContext context) : base(context)
        {
        }

        public Pedido GetPedido(int id)
        {
            var pedido = _context.Pedidos
                                    .Include(p => p.Cliente)
                                    .Include(p => p.Funcionario)
                                    .Where(p => p.Id == id)
                                    .FirstOrDefault();
            return pedido;
        }

        public List<Pedido> GetPedidos()
        {
            var pedidos = _context.Pedidos
                                        .Include(p => p.Cliente)
                                        .Include(p => p.Funcionario)
                                        .ToList();
            return pedidos;
        }

        public Pedido GetPedidoByNumero(long numeroPedido)
        {
            var pedido = _context.Pedidos
                                    .Include(p => p.Cliente)
                                    .Include(p => p.Funcionario)
                                    .Where(p => p.NumeroPedido == numeroPedido)
                                    .FirstOrDefault();
            return pedido;
        }
    }
}
