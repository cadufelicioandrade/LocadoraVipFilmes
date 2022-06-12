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
        [MaxLength(40, ErrorMessage = "Nome Ator só pode ter o máximo de 40 caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome Ator não pode ter menos de 3 caracteres.")]
        public string NomeAtor { get; set; }
        public string SobreNome { get; set; }
        public DateTime DtNascimento { get; set; }

        public virtual List<FilmeAtor> FilmeAtors { get; set; }

    }
}
