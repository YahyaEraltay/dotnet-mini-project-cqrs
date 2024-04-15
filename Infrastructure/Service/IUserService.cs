using Domain.Entities;
using Infrastructure.DTOs.User.Request;

namespace Infrastructure.Service
{
    public interface IUserService
    {
        Task<User> Create(UserRequestDto request);
        Task<User> Update(User user);   
        Task<User> Delete(User user);
        Task<List<User>> GetAll();
        Task<User> Detail(Guid id);
    }
}
