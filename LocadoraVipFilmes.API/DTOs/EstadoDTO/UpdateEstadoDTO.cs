using LocadoraVipFilmes.API.DTOs.CidadeDTO;

namespace LocadoraVipFilmes.API.DTOs.EstadoDTO
{
    public class UpdateEstadoDTO
    {
        public int Id { get; set; }
        public string NomeEstado { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public List<ReadCidadeDTO> ReadCidadeDTOs { get; set; }
    }
}
