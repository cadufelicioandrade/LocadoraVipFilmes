using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class EstadoVO : ModelBaseVO
    {
        public EstadoVO()
        {

        }

        public string NomeEstado { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }

        public List<CidadeVO> Cidades { get; set; }

    }
}
