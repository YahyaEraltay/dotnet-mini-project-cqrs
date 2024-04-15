using Infrastructure.Service;
using MediatR;

namespace Application.Users.Commands.Delete
{
    public class DeleteHandler : IRequestHandler<DeleteUserRequest, DeleteResponse>
    {
        private readonly IUserService _userService;

        public DeleteHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<DeleteResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.Detail(request.Id);
            var response = new DeleteResponse();

            if (user != null)
            {
                await _userService.Delete(user);
                response.IsDeleted = true;
                response.Message = "User deleted";
            }
            else
            {
                response.IsDeleted = false;
                response.Message = "User could not be deleted";
            }

            return response;
        }
    }
}
