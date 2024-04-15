using MediatR;

namespace Application.Users.Commands.Create
{
    public class CreateUserRequest : IRequest<CreateResponse> 
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
