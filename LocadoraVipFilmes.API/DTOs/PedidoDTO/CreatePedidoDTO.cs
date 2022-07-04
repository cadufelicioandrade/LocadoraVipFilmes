using LocadoraVipFilmes.API.DTOs.ClienteDTO;
using LocadoraVipFilmes.API.DTOs.FuncionarioDTO;
using LocadoraVipFilmes.API.DTOs.PedidoFilmeDTO;

namespace LocadoraVipFilmes.API.DTOs.PedidoDTO
{
    public class CreatePedidoDTO
    {
        public DateTime DtPedido { get; set; }
        public int QtdFilme { get; set; }
        public double ValorTotal { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public List<CreatePedidoFilmeDTO>  CreatePedidoFilmeDTOs { get; set; }
    }
}
