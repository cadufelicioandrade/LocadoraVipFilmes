using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class PedidoFilme : ModelBase
    {
        public PedidoFilme()
        {

        }

        [Required(ErrorMessage = "O campo ValorUnitario é obrigatório.")]
        [MinLength(0, ErrorMessage = "O Valor Unitário não pode ser menor de 0.")]
        public double ValorUnitario { get; set; }

        [Required(ErrorMessage = "O campo PedidoId é obrigatório.")]
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "O campo FilmeId é obrigatório.")]
        public int FilmeId { get; set; }

        public virtual Filme Filme { get; set; }
        public virtual Pedido Pedido { get; set; }

    }
}
