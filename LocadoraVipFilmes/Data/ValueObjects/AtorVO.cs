using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.Data.ValueObjects
{
    public class AtorVO
    {
        public AtorVO()
        {

        }

        public int Id { get; set; }
        public string NomeAtor { get; set; }
        public string SobreNome { get; set; }
        public DateTime DtNascimento { get; set; }

        public List<FilmeAtorVO> FilmeAtors { get; set; }


    }
}
