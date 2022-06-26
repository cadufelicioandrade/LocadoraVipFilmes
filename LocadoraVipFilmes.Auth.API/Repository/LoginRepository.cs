using FluentResults;
using LocadoraVipFilmes.Auth.API.Interfaces;
using LocadoraVipFilmes.Auth.API.Model;
using LocadoraVipFilmes.Auth.API.Requests;
using LocadoraVipFilmes.Auth.API.Services;
using Microsoft.AspNetCore.Identity;

namespace LocadoraVipFilmes.Auth.API.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private SignInManager<IdentityUser<int>> _signManager;
        private TokenService _tokenService;

        public LoginRepository(SignInManager<IdentityUser<int>> signManager, TokenService tokenService)
        {
            _signManager = signManager;
            _tokenService = tokenService;
        }

        public Result Login(LoginRequest request)
        {
            var resultadoIdentity = _signManager
                .PasswordSignInAsync(request.Username, request.Password, false, false);

            if (resultadoIdentity.Result.Succeeded)
            {
                var identityUser = _signManager.UserManager.Users
                        .FirstOrDefault(user => user.NormalizedUserName == request.Username.ToUpper());

                //recupera role do usuário
                var roleUserResult = _signManager.UserManager.GetRolesAsync(identityUser)
                                                             .Result.FirstOrDefault();

                Token token = _tokenService.CreateToken(identityUser, roleUserResult);

                return Result.Ok().WithSuccess(token.Value);
            }

            return Result.Fail("Não foi possível realizar o login.");
        }

        public Result Logout()
        {
            var resultadoIdentity = _signManager.SignOutAsync();
            
            if (resultadoIdentity.IsCompletedSuccessfully)
                return Result.Ok();

            return Result.Fail("Não foi possível realizar o logout.");
        }

        public Result RecuperarSenha(RecuperaSenhaRequest request)
        {
            IdentityUser<int>? identityUser = GetIdentiyUserByEmail(request.Email);

            if (identityUser != null)
            {
                var codigoRecuperacao = _signManager.UserManager
                                            .GeneratePasswordResetTokenAsync(identityUser).Result;

                return Result.Ok().WithSuccess(codigoRecuperacao);
            }

            return Result.Fail("Falha ao redefinir a senha, entre em contato com o suporte.");
        }

        public Result EfetuarResetSenha(ResetSenhaRequest request)
        {
            IdentityUser<int>? identityUser = GetIdentiyUserByEmail(request.Email);

            if(identityUser != null)
            {
                IdentityResult identityResult = _signManager.UserManager
                    .ResetPasswordAsync(identityUser, request.Token, request.Password).Result;

                if (identityResult.Succeeded)
                    return Result.Ok().WithSuccess("Senha redefinida com sucesso!");
            }

            return Result.Fail("Erro ao resetar senha, entrar em contato com o suporte.");
        }

        private IdentityUser<int>? GetIdentiyUserByEmail(string email) 
            =>_signManager.UserManager.Users.FirstOrDefault(u => u.NormalizedEmail == email.ToUpper());

    }
}
