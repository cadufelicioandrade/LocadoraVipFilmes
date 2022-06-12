using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Dominio.Model
{
    public class ModelBase
    {
        public ModelBase()
        {

        }

        [Required(ErrorMessage = "Campo Id é obrigatório.")]
        public int Id { get; set; }
    }
}
