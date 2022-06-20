using FluentResults;
using LocadoraVipFilmes.Auth.API.Model;
using LocadoraVipFilmes.Auth.API.Requests;
using Microsoft.AspNetCore.Identity;

namespace LocadoraVipFilmes.Auth.API.Interfaces
{
    public interface ILoginRepository
    {
        Result Login(LoginRequest request);
        Result Logout();
    }
}
