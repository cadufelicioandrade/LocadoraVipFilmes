using System.ComponentModel.DataAnnotations;

namespace LocadoraVipFilmes.Auth.API.Requests
{
    public class AtivaContaRequest
    {
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public string CodigoAtivacao { get; set; }

    }
}
