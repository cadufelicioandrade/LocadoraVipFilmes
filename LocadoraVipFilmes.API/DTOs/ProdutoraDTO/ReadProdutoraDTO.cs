using LocadoraVipFilmes.API.DTOs.FilmeDTO;

namespace LocadoraVipFilmes.API.DTOs.ProdutoraDTO
{
    public class ReadProdutoraDTO
    {
        public int Id { get; set; }

        public string NomeProdutora { get; set; }
        public List<ReadFilmeDTO> ReadFilmeDTOs { get; set; }
    }
}
