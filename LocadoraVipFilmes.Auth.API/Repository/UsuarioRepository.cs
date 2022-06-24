using AutoMapper;
using FluentResults;
using LocadoraVipFilmes.Auth.API.DTOs.UsuarioDTO;
using LocadoraVipFilmes.Auth.API.Interfaces;
using LocadoraVipFilmes.Auth.API.Model;
using LocadoraVipFilmes.Auth.API.Requests;
using LocadoraVipFilmes.Auth.API.Services;
using Microsoft.AspNetCore.Identity;
using System.Web;

namespace LocadoraVipFilmes.Auth.API.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;
        private EmailService _emailService;
        private RoleManager<IdentityRole<int>> _roleManager;

        public UsuarioRepository(IMapper mapper,
                UserManager<IdentityUser<int>> userManager,
                EmailService emailService,
                RoleManager<IdentityRole<int>> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _emailService = emailService;
            _roleManager = roleManager;
        }

        public Result CadastrarUsuario(CreateUsuarioDTO createUsuario)
        {
            Usuario usuario = _mapper.Map<Usuario>(createUsuario);
            IdentityUser<int> identityUser = _mapper.Map<IdentityUser<int>>(usuario);
            Task<IdentityResult> resultadoIdentity = _userManager
                                                        .CreateAsync(identityUser, createUsuario.Password);

            var createRoleResult = _roleManager.CreateAsync(new IdentityRole<int>("admin")).Result;
            var userRoleResult = _userManager.AddToRoleAsync(identityUser, "admin").Result;

            if (resultadoIdentity.Result.Succeeded)
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(identityUser).Result;
                var encodedCode = HttpUtility.UrlEncode(code);
                //_emailService.EnviarEmail(new[] {identityUser.Email},"Link ativação", identityUser.Id, encodedCode);
                return Result.Ok().WithSuccess(code);
            }

            return Result.Fail("Falha ao cadastrar usuário.");
        }
        public Result AtivarContaUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager.Users.FirstOrDefault(u => u.Id == request.UsuarioId);
            var identityResult = _userManager.ConfirmEmailAsync(identityUser, request.CodigoAtivacao).Result;

            if (identityResult.Succeeded)
                return Result.Ok().WithSuccess("E-mail ativado com sucesso.");

            return Result.Fail("Falha ao ativar conta de usuário");
        }

    }
}
