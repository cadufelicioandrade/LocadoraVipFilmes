using System.ComponentModel.DataAnnotations;

namespace LocadoraVipFilmes.Auth.API.Model
{
    public class Usuario
    {
        public Usuario()
        {

        }

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        [EmailAddress(ErrorMessage ="E-mail no formato errado.")]
        public string Email { get; set; }

    }
}
