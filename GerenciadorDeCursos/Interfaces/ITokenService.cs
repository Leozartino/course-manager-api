using GerenciadorDeCursos.Models;

namespace GerenciadorDeCursos.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
