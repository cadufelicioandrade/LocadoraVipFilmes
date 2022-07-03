using LocadoraVipFilmes.API.DTOs.AtorDTO;

namespace LocadoraVipFilmes.API.DTOs.FilmeDTO
{
    public class CreateFilmeDTO
    {
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int AnoLancamento { get; set; }
        public bool Disponivel { get; set; }
        public double ValorLocacao { get; set; }
        public int GeneroId { get; set; }
        public int ProdutoraId { get; set; }

        public List<ReadAtorDTO> ReadAtorDTOs { get; set; }
    }
}
