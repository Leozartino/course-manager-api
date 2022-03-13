using GerenciadorDeCursos.Dtos.Incoming;

namespace GerenciadorDeCursos.Interfaces
{
    public interface IAccountService
    {
        bool VerifyPassword(string passwordIncoming, string userPassword);
    }
}
