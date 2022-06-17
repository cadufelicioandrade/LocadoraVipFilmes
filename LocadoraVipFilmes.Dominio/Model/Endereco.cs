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
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Logradouro deve ter entre 3 e 50 caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Bairro deve ter entre 3 e 25 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Bairro deve ter entre 5 e 15 caracteres.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo Numero é obrigatório.")]
        [Range(0, 100000, ErrorMessage = "O Número não pode ser menor que zero.")]
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
