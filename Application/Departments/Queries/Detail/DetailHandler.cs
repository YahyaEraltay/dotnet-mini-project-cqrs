using Infrastructure.Service;
using MediatR;

namespace Application.Department.Queries.Detail
{
    public class DetailHandler : IRequestHandler<DetailRequest, DetailResponse>
    {
        private readonly IDepartmentService _departmentService;

        public DetailHandler(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<DetailResponse> Handle(DetailRequest request, CancellationToken cancellationToken)
        {
            var department =  await _departmentService.Detail(request.Id);

            if (department != null)
            {
                var response = new DetailResponse()
                {
                    Id = department.Id,
                    DepartmentName = department.DepartmentName,
                    DepartmentDescription = department.DepartmentDescription
                };

                return response;
            }
            else
            {
                throw new Exception("There is no department");
            }
        }
    }
}
