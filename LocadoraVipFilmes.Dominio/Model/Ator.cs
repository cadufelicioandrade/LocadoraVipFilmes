using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Ator : ModelBase
    {
        public Ator()
        {

        }

        [Required(ErrorMessage = "O campo NomeAtor é obrigatório.")]
        [StringLength(35,MinimumLength = 3, ErrorMessage ="Nome Ator deve ter entre 3 e 35 caracteres.")]
        public string NomeAtor { get; set; }
        
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Nome Ator deve ter entre 3 e 35 caracteres.")]
        public string SobreNome { get; set; }
        public DateTime DtNascimento { get; set; }

        public virtual List<FilmeAtor> FilmeAtors { get; set; }

    }
}
