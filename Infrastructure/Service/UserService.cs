using Domain.Entities;
using Infrastructure.DTOs.User.Request;
using Infrastructure.Repository;

namespace Infrastructure.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Create(UserRequestDto request)
        {
            var user = new User()
            {
                UserName = request.UserName,
                UserEmail = request.UserEmail,
                DepartmentId = request.DepartmentId
            };

            await _userRepository.Create(user);

            return user;
        }

        public async Task<User> Delete(User user)
        {
            return await _userRepository.Delete(user);
        }

        public async Task<User> Detail(Guid id)
        {
            return await _userRepository.Detail(id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public Task<User> Update(User user)
        {
            return _userRepository.Update(user);
        }
    }
}
