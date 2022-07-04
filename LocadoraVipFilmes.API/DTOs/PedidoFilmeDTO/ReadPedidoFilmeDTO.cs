using LocadoraVipFilmes.API.DTOs.FilmeDTO;
using LocadoraVipFilmes.API.DTOs.PedidoDTO;

namespace LocadoraVipFilmes.API.DTOs.PedidoFilmeDTO
{
    public class ReadPedidoFilmeDTO
    {
        public int Id { get; set; }
        public double ValorUnitario { get; set; }
        public int PedidoId { get; set; }
        public int FilmeId { get; set; }
    }
}
