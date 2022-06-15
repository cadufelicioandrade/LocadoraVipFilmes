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
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Gênero deve ter entre 3 e 35 caracteres.")]
        public string NomeGenero { get; set; }

        public virtual List<Filme>  Filmes { get; set; }

    }
}
