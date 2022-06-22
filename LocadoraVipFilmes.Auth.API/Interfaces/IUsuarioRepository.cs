using FluentResults;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;
using LocadoraVipFilmes.Auth.API.Requests;

namespace LocadoraVipFilmes.Auth.API.Interfaces
{
    public interface IUsuarioRepository
    {
        Result CadastrarUsuario(CreateUsuarioDTO createUsuario);
        Result AtivarContaUsuario(AtivaContaRequest request);
    }
}
