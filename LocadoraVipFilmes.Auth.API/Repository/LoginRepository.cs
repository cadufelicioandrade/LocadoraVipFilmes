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

                Token token = _tokenService.CreateToken(identityUser);

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
    }
}
