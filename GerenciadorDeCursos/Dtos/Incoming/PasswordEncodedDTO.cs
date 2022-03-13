namespace GerenciadorDeCursos.Dtos.Incoming
{
    public class PasswordEncodedDTO
    {
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
