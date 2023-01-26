using ApiCatalogoMinimalAPI.Models;

namespace ApiCatalogoMinimalAPI.Services
{
    public interface ITokenService
    {
        string gerarToken(string key, string issuer, string audience, UserModel user);
    }
}
