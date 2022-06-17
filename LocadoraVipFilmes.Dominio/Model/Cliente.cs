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
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Nome Cliente deve ter entre 3 e 35 caracteres.")]
        public string NomeCliente { get; set; }
    }
}
