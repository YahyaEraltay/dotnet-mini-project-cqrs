using Infrastructure.Service;
using MediatR;

namespace Application.Users.Queries.All
{
    public class AllHandler : IRequestHandler<AllUserRequest, List<AllResponse>>
    {
        private readonly IUserService _userService;

        public AllHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<List<AllResponse>> Handle(AllUserRequest request, CancellationToken cancellationToken)
        {
            var users = await _userService.GetAll();
            var response = new List<AllResponse>();

            if (users != null)
            {
                foreach (var user in users)
                {
                    response.Add(new AllResponse
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        UserEmail = user.UserEmail,
                        DepartmentName = user.Department.DepartmentName
                    });
                }
                return response;
            }
            else
            {
                throw new Exception("There is no user");
            }
        }
    }
}
