using FluentResults;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;

namespace LocadoraVipFilmes.Auth.API.Interfaces
{
    public interface IUsuarioRepository
    {
        Result CadastrarUsuario(CreateUsuarioDTO createUsuario);
    }
}
