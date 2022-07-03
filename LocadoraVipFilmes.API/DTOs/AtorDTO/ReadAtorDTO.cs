using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVipFilmes.API.DTOs.AtorDTO
{
    public class ReadAtorDTO
    {
        public ReadAtorDTO()
        {

        }
        public int Id { get; set; }
        public string NomeAtor { get; set; }
        public string SobreNome { get; set; }
        public DateTime DtNascimento { get; set; }
    }
}
