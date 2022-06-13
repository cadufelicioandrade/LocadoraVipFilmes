using LocadoraVipFilmes.API.DTOs.FilmeDTO;

namespace LocadoraVipFilmes.API.DTOs.GeneroDTO
{
    public class UpdateGeneroDTO
    {
        public int Id { get; set; }
        public string NomeGenero { get; set; }
        public List<ReadFilmeDTO> ReadFilmeDTOs { get; set; }
    }
}
