using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.API.Data.ValueObjects
{
    public class FilmeAtorVO : ModelBaseVO
    {
        public FilmeAtorVO()
        {

        }

        public AtorVO Ator { get; set; }
        public int AtorId { get; set; }

        public FilmeVO Filme { get; set; }
        public int FilmeId { get; set; }

    }
}
