using GerenciadorDeCursos.Interfaces;

namespace GerenciadorDeCursos.Services
{
    public class AccountService : IAccountService
    {
        public bool VerifyPassword(string passwordIncoming, string userPassword)

        {
            bool result = passwordIncoming.Equals(userPassword);

            return result;
            
        }
    }
}
