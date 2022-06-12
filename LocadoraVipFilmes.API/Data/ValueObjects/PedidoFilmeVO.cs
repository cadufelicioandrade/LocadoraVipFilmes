using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.API.Data.ValueObjects
{
    public class PedidoFilmeVO : ModelBaseVO
    {
        public PedidoFilmeVO()
        {

        }

        public double ValorUnitario { get; set; }

        public PedidoVO Pedido { get; set; }
        public int PedidoId { get; set; }

        public FilmeVO Filme { get; set; }
        public int FilmeId { get; set; }

    }
}
