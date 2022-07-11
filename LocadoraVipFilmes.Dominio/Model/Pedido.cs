using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Pedido : ModelBase
    {
        public Pedido()
        {

        }

        [Required(ErrorMessage = "O campo DtPedido é obrigatório.")]
        public DateTime DtPedido { get; set; }

        [Required(ErrorMessage = "O campo QtdFilme é obrigatório.")]
        [MinLength(0, ErrorMessage = "A QtdFilme não pode ter menos de 0.")]
        public int QtdFilme { get; set; }

        [Required(ErrorMessage = "O campo ValorTotal é obrigatório.")]
        [MinLength(0, ErrorMessage = "O ValorTotal não pode ter menos de 0.")]
        public double ValorTotal { get; set; }

        [Required]
        public long NumeroPedido { get; set; }

        [Required(ErrorMessage = "O campo ClienteId é obrigatório.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O campo FuncionarioId é obrigatório.")]
        public int FuncionarioId { get; set; }


        public virtual Cliente Cliente { get; set; }
        public virtual List<PedidoFilme> PedidoFilmes { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
