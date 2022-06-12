using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class PedidoVO : ModelBaseVO
    {
        public PedidoVO()
        {

        }

        public DateTime DtPedido { get; set; }
        public int QtdFilme { get; set; }
        public double ValorTotal { get; set; }

        public ClienteVO Cliente { get; set; }
        public int ClienteId { get; set; }

        public FuncionarioVO Funcionario { get; set; }
        public int FuncionarioId { get; set; }

        public List<PedidoFilmeVO> PedidoFilmes { get; set; }
    }
}
