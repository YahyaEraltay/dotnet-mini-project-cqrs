using MediatR;

namespace Application.Users.Queries.Detail
{
    public class DetailUserRequest : IRequest<DetailResponse>
    {
        public Guid Id { get; set; }
    }
}
