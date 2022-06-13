using LocadoraVipFilmes.API.DTOs.ClienteDTO;
using LocadoraVipFilmes.API.DTOs.FuncionarioDTO;
using LocadoraVipFilmes.API.DTOs.PedidoFilmeDTO;

namespace LocadoraVipFilmes.API.DTOs.PedidoDTO
{
    public class UpdatePedidoDTO
    {
        public int Id { get; set; }
        public DateTime DtPedido { get; set; }
        public int QtdFilme { get; set; }
        public double ValorTotal { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public ReadClienteDTO ReadClienteDTO { get; set; }
        public List<ReadPedidoFilmeDTO> ReadPedidoFilmeDTOs { get; set; }
        public ReadFuncionarioDTO ReadFuncionarioDTO { get; set; }
    }
}
