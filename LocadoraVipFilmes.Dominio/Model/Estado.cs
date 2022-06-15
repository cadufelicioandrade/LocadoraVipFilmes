using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Estado : ModelBase
    {
        public Estado()
        {

        }

        [Required(ErrorMessage = "O campo NomeEstado é obrigatório.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Estado deve ter entre 2 e 15 caracteres.")]
        public string NomeEstado { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "UF deve ter 2 caracteres.")]
        public string UF { get; set; }

        [Required(ErrorMessage = "O campo Pais é obrigatório.")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "País deve ter 5 caracteres.")]
        public string Pais { get; set; }

        public virtual List<Cidade> Cidades { get; set; }

    }
}
