using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class FilmeAtor : ModelBase
    {
        public FilmeAtor()
        {

        }

        [Required(ErrorMessage = "O campo AtorId é obrigatório.")]
        public int AtorId { get; set; }

        [Required(ErrorMessage = "O campo FilmeId é obrigatório.")]
        public int FilmeId { get; set; }

        public virtual Filme Filme { get; set; }
        public virtual Ator Ator { get; set; }

    }
}
