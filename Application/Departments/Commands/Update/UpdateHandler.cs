using Infrastructure.Service;
using MediatR;

namespace Application.Department.Commands.Update
{
    public class UpdateHandler : IRequestHandler<UpdateRequest, UpdateResponse>
    {
        private readonly IDepartmentService _departmentService;

        public UpdateHandler(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<UpdateResponse> Handle(UpdateRequest request, CancellationToken cancellationToken)
        {
            var department = await _departmentService.Detail(request.Id);

            if (department != null)
            {
                department.DepartmentName = request.DepartmentName;
                department.DepartmentDescription = request.DepartmentDescription;

                await _departmentService.Update(department);
            }
            else
            {
                throw new Exception("Department could not be updated");
            }

            var response = new UpdateResponse()
            {
                DepartmentName = department.DepartmentName,
                DepartmentDescription = department.DepartmentDescription
            };

            return response;
        }
    }
}
