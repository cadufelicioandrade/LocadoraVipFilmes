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
        public string NomeProdutora { get; set; }
        public virtual List<Filme> Filmes { get; set; }

    }
}
