using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class CidadeVO : ModelBaseVO
    {
        public CidadeVO()
        {

        }

        public string NomeCidade { get; set; }

        public virtual EstadoVO Estado { get; set; }
        public int EstadoId { get; set; }

        public List<EnderecoVO> Enderecos { get; set; }

    }
}
