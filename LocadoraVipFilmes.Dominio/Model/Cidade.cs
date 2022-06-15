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
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Nome Cidade deve ter entre 3 e 30 caracteres.")]
        public string NomeCidade { get; set; }

        [Required(ErrorMessage = "O campo EstadoId é obrigatório.")]
        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual List<Endereco> Enderecos { get; set; }

    }
}
