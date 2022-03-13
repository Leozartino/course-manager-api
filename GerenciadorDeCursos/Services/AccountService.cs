using GerenciadorDeCursos.Interfaces;

namespace GerenciadorDeCursos.Services
{
    public class AccountService : IAccountService
    {
        public bool VerifyPasswordHash(string passwordIncoming, string userPassword)

        {
            bool result = passwordIncoming.Equals(userPassword);

            return result;
            
        }
    }
}
