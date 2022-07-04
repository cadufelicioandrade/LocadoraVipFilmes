using LocadoraVipFilmes.API.DTOs.GeneroDTO;
using LocadoraVipFilmes.API.DTOs.PedidoFilmeDTO;
using LocadoraVipFilmes.API.DTOs.ProdutoraDTO;

namespace LocadoraVipFilmes.API.DTOs.FilmeAtorDTO
{
    public class UpdateFilmeAtorDTO
    {
        public int Id { get; set; }
        public int AtorId { get; set; }
        public int FilmeId { get; set; }
    }
}
