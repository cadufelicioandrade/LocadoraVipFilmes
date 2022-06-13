using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Genero : ModelBase
    {
        public Genero()
        {

        }

        [Required(ErrorMessage = "O campo NomeGenero é obrigatório.")]
        [MaxLength(25, ErrorMessage = "O Nome Genero não pode ter mais de 25 caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome Genero não pode ter menos de 3 caracteres.")]
        public string NomeGenero { get; set; }

        public virtual List<Filme>  Filmes { get; set; }

    }
}
