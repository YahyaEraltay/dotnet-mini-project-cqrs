using MediatR;

namespace Application.Department.Queries.All
{
    public class AllRequest : IRequest<List<AllResponse>>
    {
    }
}
