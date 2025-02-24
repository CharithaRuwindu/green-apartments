using Backend.Models;

namespace Backend.Services
{
    public interface IUserService
    {
        Task<UserDTO> RegisterUserAsync(UserModel model);
        Task<UserDTO?> GetUserByIdAsync(Guid id);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
    }
}
