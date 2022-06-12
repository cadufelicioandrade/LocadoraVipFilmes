using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Endereco : ModelBase
    {
        public Endereco()
        {

        }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório.")]
        [MaxLength(40, ErrorMessage = "Logradouro só pode ter o máximo de 40 caracteres.")]
        [MinLength(5, ErrorMessage = "O Logradouro não pode ter menos de 5 caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        [MaxLength(25, ErrorMessage = "O Bairro só pode ter o máximo de 25 caracteres.")]
        [MinLength(5, ErrorMessage = "O Bairro não pode ter menos de 5 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [MaxLength(15, ErrorMessage = "O CEP só pode ter o máximo de 15 caracteres.")]
        [MinLength(5, ErrorMessage = "O CEP não pode ter menos de 5 caracteres.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo Numero é obrigatório.")]
        [MinLength(0, ErrorMessage = "O Número não pode ser menor que zero.")]
        public int Numero { get; set; }

        public int? ClienteId { get; set; }

        public int? FuncionarioId { get; set; }

        [Required(ErrorMessage = "O campo CidadeId é obrigatório.")]
        public int CidadeId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
