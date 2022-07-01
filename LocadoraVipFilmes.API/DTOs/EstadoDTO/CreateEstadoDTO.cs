using LocadoraVipFilmes.API.DTOs.CidadeDTO;

namespace LocadoraVipFilmes.API.DTOs.EstadoDTO
{
    public class CreateEstadoDTO
    {
        public string NomeEstado { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
    }
}
