using AutoMapper;
using FluentResults;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;
using LocadoraVipFilmes.Auth.API.Interfaces;
using LocadoraVipFilmes.Auth.API.Model;
using Microsoft.AspNetCore.Identity;

namespace LocadoraVipFilmes.Auth.API.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;

        public UsuarioRepository(IMapper mapper, 
                UserManager<IdentityUser<int>> userManager = null)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public Result CadastrarUsuario(CreateUsuarioDTO createUsuario)
        {
            Usuario usuario = _mapper.Map<Usuario>(createUsuario);
            IdentityUser<int> identityUser = _mapper.Map<IdentityUser<int>>(usuario);
            Task<IdentityResult> resultadoIdentity = _userManager.CreateAsync(identityUser, createUsuario.Password);

            if (resultadoIdentity.Result.Succeeded)
                return Result.Ok();

            return Result.Fail("Falha ao cadastrar usuário.");
        }
    }
}
