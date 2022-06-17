using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Pessoa : ModelBase
    {
        [Required(ErrorMessage = "O campo SobreNome é obrigatório.")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "SobreNome deve ter entre 3 e 35 caracteres.")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [MaxLength(11, ErrorMessage = "CPF não pode ter mais de 11 caracteres.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo RG é obrigatório.")]
        [MaxLength(9, ErrorMessage = "RG não pode ter mais de 9 caracteres.")]
        public string RG { get; set; }

        [MaxLength(20, ErrorMessage = "TelFixo não pode ter mais de 9 caracteres.")]
        public string TelFixo { get; set; }

        [Required(ErrorMessage = "O campo Celular é obrigatório.")]
        [MaxLength(20, ErrorMessage = "Celular não pode ter mais de 9 caracteres.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage ="Verifique o formado do e-mail.")]
        [MaxLength(60, ErrorMessage = "E-mail não pode ter mais de 60 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo DtNascimento é obrigatório.")]
        public DateTime DtNascimento { get; set; }
        
        public bool Ativo { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }

    }
}
