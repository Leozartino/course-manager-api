using GerenciadorDeCursos.Data;
using GerenciadorDeCursos.Dtos.Incoming;
using GerenciadorDeCursos.Interfaces;
using GerenciadorDeCursos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _appDbContext.Users.Add(user);
            await _appDbContext.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteUserAsync(User user)
        {
            _appDbContext.Users.Remove(user);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users = await _appDbContext.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            var user = await _appDbContext.Users.FindAsync(id);
            return user;
        }

        public User GetUserByUsername(string username)
        {
            var user = _appDbContext.Users.Where((User u) => u.Username == username).FirstOrDefault();
            return user;

        }

        public async Task<User> UpdateUserAsync(User user, UserUpdateDTO userUpdateDTO)
        {
            user.Name = userUpdateDTO.Name;
            user.Role = userUpdateDTO.Role;

            await _appDbContext.SaveChangesAsync();

            return user;
        }
    }
}
