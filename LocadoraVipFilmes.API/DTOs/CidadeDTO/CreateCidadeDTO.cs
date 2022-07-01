using LocadoraVipFilmes.API.DTOs.EnderecoDTO;
using LocadoraVipFilmes.API.DTOs.EstadoDTO;

namespace LocadoraVipFilmes.API.DTOs.CidadeDTO
{
    public class CreateCidadeDTO
    {
        public CreateCidadeDTO()
        {

        }

        public string NomeCidade { get; set; }
        public int EstadoId { get; set; }
    }
}
