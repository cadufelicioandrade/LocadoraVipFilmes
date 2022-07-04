using LocadoraVipFilmes.API.DTOs.AtorDTO;
using LocadoraVipFilmes.API.DTOs.FilmeDTO;

namespace LocadoraVipFilmes.API.DTOs.FilmeAtorDTO
{
    public class ReadFilmeAtorDTO
    {
        public int Id { get; set; }
        public int AtorId { get; set; }
        public int FilmeId { get; set; }
        public ReadFilmeDTO ReadFilmeDTO { get; set; }
        public ReadAtorDTO ReadAtorDTO { get; set; }
    }
}
