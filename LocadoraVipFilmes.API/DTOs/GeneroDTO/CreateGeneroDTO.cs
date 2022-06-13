using LocadoraVipFilmes.API.DTOs.FilmeDTO;

namespace LocadoraVipFilmes.API.DTOs.GeneroDTO
{
    public class CreateGeneroDTO
    {
        public string NomeGenero { get; set; }
        public List<ReadFilmeDTO>  ReadFilmeDTOs { get; set; }
    }
}
