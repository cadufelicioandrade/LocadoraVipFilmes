using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.API.Data.ValueObjects
{
    public class ProdutoraVO : ModelBaseVO
    {
        public ProdutoraVO()
        {

        }

        public string NomeProdutora { get; set; }
        public List<FilmeVO> Filmes { get; set; }

    }
}
