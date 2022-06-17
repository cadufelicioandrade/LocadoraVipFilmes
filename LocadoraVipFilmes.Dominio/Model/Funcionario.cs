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
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Nome funcionário deve ter entre 3 e 35 caracteres.")]
        public string NomeFuncionario { get; set; }
    }
}
