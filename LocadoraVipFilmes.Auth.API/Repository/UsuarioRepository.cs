using AutoMapper;
using FluentResults;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;
using LocadoraVipFilmes.Auth.API.Interfaces;
using LocadoraVipFilmes.Auth.API.Model;
using LocadoraVipFilmes.Auth.API.Requests;
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

        public Result AtivarContaUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager.Users.FirstOrDefault(u => u.Id == request.UsuarioId);
            var identityResult = _userManager.ConfirmEmailAsync(identityUser, request.CodigoAtivacao).Result;

            if (identityResult.Succeeded)
                return Result.Ok().WithSuccess("E-mail ativado com sucesso.");

            return Result.Fail("Falha ao ativar conta de usuário");
        }

        public Result CadastrarUsuario(CreateUsuarioDTO createUsuario)
        {
            Usuario usuario = _mapper.Map<Usuario>(createUsuario);
            IdentityUser<int> identityUser = _mapper.Map<IdentityUser<int>>(usuario);
            Task<IdentityResult> resultadoIdentity = _userManager.CreateAsync(identityUser, createUsuario.Password);

            if (resultadoIdentity.Result.Succeeded)
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(identityUser).Result;
                return Result.Ok().WithSuccess(code);
            }

            return Result.Fail("Falha ao cadastrar usuário.");
        }
    }
}
