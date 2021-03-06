using LocadoraVipFilmes.API.DTOs.FilmeAtorDTO;
using LocadoraVipFilmes.API.DTOs.GeneroDTO;
using LocadoraVipFilmes.API.DTOs.PedidoFilmeDTO;
using LocadoraVipFilmes.API.DTOs.ProdutoraDTO;

namespace LocadoraVipFilmes.API.DTOs.FilmeDTO
{
    public class ReadFilmeDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int AnoLancamento { get; set; }
        public bool Disponivel { get; set; }
        public double ValorLocacao { get; set; }
        public int GeneroId { get; set; }
        public int ProdutoraId { get; set; }
        public ReadGeneroDTO ReadGeneroDTO { get; set; }
        public ReadProdutoraDTO ReadProdutoraDTO { get; set; }
        public virtual List<ReadPedidoFilmeDTO> ReadPedidoFilmeDTOs { get; set; }
    }
}
