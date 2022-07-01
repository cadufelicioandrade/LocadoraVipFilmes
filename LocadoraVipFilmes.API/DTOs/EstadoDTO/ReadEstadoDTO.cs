using LocadoraVipFilmes.API.DTOs.CidadeDTO;

namespace LocadoraVipFilmes.API.DTOs.EstadoDTO
{
    public class ReadEstadoDTO
    {
        public int Id { get; set; }
        public string NomeEstado { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
    }
}
