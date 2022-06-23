using System.ComponentModel.DataAnnotations;

namespace LocadoraVipFilmes.Auth.API.Requests
{
    public class RecuperaSenhaRequest
    {
        [Required]
        public string Email { get; set; }

    }
}
