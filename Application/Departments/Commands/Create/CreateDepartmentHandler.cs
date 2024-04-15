using Infrastructure.DTOs.Department.Request;
using Infrastructure.Service;
using MediatR;

namespace Application.Department.Commands.Create
{
    public class CreateDepartmentHandler : IRequestHandler<CreateRequest, CreateResponse>
    {
        private readonly IDepartmentService _departmentService;

        public CreateDepartmentHandler(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<CreateResponse> Handle(CreateRequest request, CancellationToken cancellationToken)
        {
            var department = new CreateRequestDto()
            {
                DepartmentName = request.DepartmentName,
                DepartmentDescription = request.DepartmentDescription
            };

            await _departmentService.Create(department);

            var response = new CreateResponse()
            {
                Id = department.Id,
                DepartmentName = department.DepartmentName,
                DepartmentDescription = department.DepartmentDescription
            };

            return response;
        }
    }
}
