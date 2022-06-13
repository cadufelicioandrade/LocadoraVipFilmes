using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Funcionario : Pessoa
    {
        public Funcionario()
        {

        }

        [Required(ErrorMessage = "O campo NomeFuncionario é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome Funcionario não pode ter mais de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome Funcionario não pode ter menos de 3 caracteres.")]
        public string NomeFuncionario { get; set; }
    }
}
