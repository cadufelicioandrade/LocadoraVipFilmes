using LocadoraVipFilmes.Auth.API.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LocadoraVipFilmes.Auth.API.Services
{
    public class TokenService
    {
        public Token CreateToken(IdentityUser<int> user) 
        {
            Claim[] claims = new Claim[]
            {
                new Claim("username", user.UserName),
                new Claim("id", user.Id.ToString())
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("0esad3asdf03lsiepqa847aoeiu23oaiacnzmb8eyrus"));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                                claims: claims,
                                signingCredentials: credentials,
                                expires: DateTime.UtcNow.AddMinutes(30));

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return new Token(tokenString);
        }
    }
}
