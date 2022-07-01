using LocadoraVipFilmes.API.DTOs.EnderecoDTO;
using LocadoraVipFilmes.API.DTOs.PedidoDTO;

namespace LocadoraVipFilmes.API.DTOs.ClienteDTO
{
    public class CreateClienteDTO
    {
        public string NomeCliente { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string TelFixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public bool Ativo { get; set; }
        public CreateEnderecoDTO CreateEnderecoDTO { get; set; }
    }
}
