using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Cidade : ModelBase
    {
        public Cidade()
        {

        }

        [Required(ErrorMessage = "O campo NomeCidade é obrigatório.")]
        [MaxLength(30, ErrorMessage = "Nome Cidade só pode ter o máximo de 30 caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome Cidade não pode ter menos de 3 caracteres.")]
        public string NomeCidade { get; set; }

        [Required(ErrorMessage = "O campo EstadoId é obrigatório.")]
        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual List<Endereco> Enderecos { get; set; }

    }
}
