using GerenciadorDeCursos.Dtos.Incoming;
using GerenciadorDeCursos.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Interfaces
{
    public interface IUserRepository
    {

        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
        User GetUserByUsername(string username);
        Task<User> UpdateUserAsync(User user, UserUpdateDTO userUpdateDTO);
        Task<User> CreateUserAsync(User user);
        Task<bool> DeleteUserAsync(User user);

    }
}
