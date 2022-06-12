using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class GeneroVO : ModelBaseVO
    {
        public GeneroVO()
        {

        }

        public string NomeGenero { get; set; }
        public List<FilmeVO>  Filmes { get; set; }

    }
}
