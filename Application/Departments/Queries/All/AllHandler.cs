using Application.Department.Queries.All;
using Infrastructure.Service;
using MediatR;

namespace Application.Departments.Queries.All
{
    public class AllHandler : IRequestHandler<AllRequest, List<AllResponse>>
    {
        private readonly IDepartmentService _departmentService;

        public AllHandler(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<List<AllResponse>> Handle(AllRequest request, CancellationToken cancellationToken)
        {
            var departments = await _departmentService.GetAll();
            var response = new List<AllResponse>();

            if (departments != null)
            {
                foreach (var department in departments)
                {
                    response.Add(new AllResponse
                    {
                        Id = department.Id,
                        DepartmentName = department.DepartmentName,
                        DepartmentDescription = department.DepartmentDescription
                    });
                }
            }
            else
            {
                throw new Exception("There is no department");
            }

            return response;
        }
    }
}
