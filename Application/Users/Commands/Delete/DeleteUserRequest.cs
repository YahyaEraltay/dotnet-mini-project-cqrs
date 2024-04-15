using MediatR;

namespace Application.Users.Commands.Delete
{
    public class DeleteUserRequest : IRequest<DeleteResponse>
    {
        public Guid Id { get; set; }
    }
}
