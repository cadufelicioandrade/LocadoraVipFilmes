using LocadoraVipFilmes.API.DTOs.EnderecoDTO;
using LocadoraVipFilmes.API.DTOs.EstadoDTO;

namespace LocadoraVipFilmes.API.DTOs.CidadeDTO
{
    public class ReadCidadeDTO
    {
        public ReadCidadeDTO()
        {

        }

        public int Id { get; set; } 
        public string NomeCidade { get; set; }

        public int EstadoId { get; set; }

        public ReadEstadoDTO ReadEstadoDTO { get; set; }

    }
}
