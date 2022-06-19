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
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(LocadoraContext context) : base(context)
        {
        }

        public async void AdicionarPedidoFilme(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.PedidoFilmes.AddRange(pedido.PedidoFilmes);
            await _context.SaveChangesAsync();
        }
    }
}
