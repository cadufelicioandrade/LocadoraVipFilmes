﻿using System.ComponentModel.DataAnnotations;

namespace LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO
{
    public class CreateUsuarioDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage ="As senhas precisam ser iguais.")]
        public string RePassword { get; set; }

    }
}
