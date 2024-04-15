using Infrastructure.Service;
using MediatR;

namespace Application.Users.Commands.Update
{
    public class UpdateHandler : IRequestHandler<UpdateUserRequest, UpdateResponse>
    {
        private readonly IUserService _userService;

        public UpdateHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdateResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.Detail(request.Id);

            if (user != null)
            {
                user.UserName = request.UserName;
                user.UserEmail = request.UserEmail;
                user.DepartmentId = request.DepartmentId;
                
                await _userService.Update(user);
            }
            else
            {
                throw new Exception("User could not be updated");
            }

            var respose = new UpdateResponse()
            {
                Id = user.Id,
                UserName = user.UserName,
                UserEmail = user.UserEmail,
                DepartmentName = user.Department.DepartmentName
            };

            return respose;
        }
    }
}
