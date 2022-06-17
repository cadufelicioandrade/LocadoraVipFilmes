using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class Produtora : ModelBase
    {
        public Produtora()
        {

        }

        [Required(ErrorMessage = "O campo NomeProdutora é obrigatório.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "NomeProdutora deve ter entre 3 e 30 caracteres.")]
        public string NomeProdutora { get; set; }
        public virtual List<Filme> Filmes { get; set; }

    }
}
