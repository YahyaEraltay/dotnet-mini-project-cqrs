using MediatR;

namespace Application.Users.Commands.Update
{
    public class UpdateUserRequest : IRequest<UpdateResponse>
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
