using Backend.Entities;
using Backend.Models;
using Backend.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace Backend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDTO> RegisterUserAsync(UserModel model)
        {
            var user = new User
            {
                UserId = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                NormalizedEmail = NormalizeEmail(model.Email),
                HashedPassword = HashPassword(model.Password),
                Role = "User",
                EmailVerified = false,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                LastLogin = null
            };

            var createdUser = await _userRepository.CreateUserAsync(user);
            return new UserDTO
            {
                UserId = createdUser.UserId,
                FirstName = createdUser.FirstName,
                LastName = createdUser.LastName,
                Email = createdUser.Email,
                IsActive = createdUser.IsActive
            };
        }

        public async Task<UserDTO?> GetUserByIdAsync(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) return null;

            return new UserDTO
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IsActive = user.IsActive
            };
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        private string NormalizeEmail(string email)
        {
            return email.Trim().ToUpperInvariant();
        }
    }
}
