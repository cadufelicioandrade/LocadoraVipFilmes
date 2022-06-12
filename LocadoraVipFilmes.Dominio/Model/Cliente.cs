using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {

        }

        [Required(ErrorMessage = "O campo NomeCliente é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome Cliente não pode ter mais de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "O Nome Cliente não pode ter menos de 3 caracteres.")]
        public string NomeCliente { get; set; }
    }
}
