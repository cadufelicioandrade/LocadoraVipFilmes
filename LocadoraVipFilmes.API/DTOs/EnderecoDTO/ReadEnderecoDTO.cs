using LocadoraVipFilmes.API.DTOs.CidadeDTO;
using LocadoraVipFilmes.API.DTOs.ClienteDTO;
using LocadoraVipFilmes.API.DTOs.FuncionarioDTO;

namespace LocadoraVipFilmes.API.DTOs.EnderecoDTO
{
    public class ReadEnderecoDTO
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public int? ClienteId { get; set; }
        public int? FuncionarioId { get; set; }
        public int CidadeId { get; set; }

        public ReadCidadeDTO ReadCidadeDTO { get; set; }
    }
}
