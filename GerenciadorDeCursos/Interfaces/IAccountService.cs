using GerenciadorDeCursos.Dtos.Incoming;

namespace GerenciadorDeCursos.Interfaces
{
    public interface IAccountService
    {
        bool VerifyPasswordHash(string passwordIncoming, string userPassword);
    }
}
