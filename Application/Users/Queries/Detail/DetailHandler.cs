using Infrastructure.Service;
using MediatR;

namespace Application.Users.Queries.Detail
{
    public class DetailHandler : IRequestHandler<DetailUserRequest, DetailResponse>
    {
        private readonly IUserService _userService;

        public DetailHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<DetailResponse> Handle(DetailUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.Detail(request.Id);

            if (user != null)
            {
                var response = new DetailResponse()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    UserEmail = user.UserEmail,
                    DepartmentName = user.Department.DepartmentName
                };

                return response;
            }
            else
            {
                throw new Exception("User could not found");
            }


        }
    }
}
