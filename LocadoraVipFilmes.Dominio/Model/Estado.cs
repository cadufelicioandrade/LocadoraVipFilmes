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

        [MaxLength(20, ErrorMessage = "O Estado só pode ter o máximo de 20 caracteres.")]
        [Required(ErrorMessage = "O campo NomeEstado é obrigatório.")]
        public string NomeEstado { get; set; }

        [MaxLength(2, ErrorMessage = "O UF só pode ter o máximo de 2 caracteres.")]
        [Required(ErrorMessage = "O campo UF é obrigatório.")]
        public string UF { get; set; }

        [MaxLength(10, ErrorMessage = "O Pais só pode ter o máximo de 10 caracteres.")]
        [Required(ErrorMessage = "O campo Pais é obrigatório.")]
        public string Pais { get; set; }

        public virtual List<Cidade> Cidades { get; set; }

    }
}
