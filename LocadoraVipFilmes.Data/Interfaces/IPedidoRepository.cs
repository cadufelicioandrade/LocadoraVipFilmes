using LocadoraVipFilmes.Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.Interfaces
{
    public interface IPedidoRepository : IBaseRepository<Pedido>
    {
        Pedido GetPedido(int id);
        List<Pedido> GetPedidos();
        Pedido GetPedidoByNumero(long numeroPedido);
    }
}
