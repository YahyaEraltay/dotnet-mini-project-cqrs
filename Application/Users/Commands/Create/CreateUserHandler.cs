using Infrastructure.DTOs.User.Request;
using Infrastructure.Service;
using MediatR;

namespace Application.Users.Commands.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateResponse>
    {
        private readonly IUserService _userService;

        public CreateUserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = new UserRequestDto()
            {
                UserName = request.UserName,
                UserEmail = request.UserEmail,
                DepartmentId = request.DepartmentId
            };

            await _userService.Create(user);

            var response = new CreateResponse()
            {
                Id = user.Id,
                UserName = user.UserName,
                UserEmail = user.UserEmail,
                DepartmentId = user.DepartmentId
            };

            return response;
        }
    }
}
