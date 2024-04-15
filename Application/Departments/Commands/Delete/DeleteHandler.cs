using Infrastructure.Service;
using MediatR;

namespace Application.Department.Commands.Delete
{
    public class DeleteHandler : IRequestHandler<DeleteRequest, DeleteResponse>
    {
        private readonly IDepartmentService _departmentService;

        public DeleteHandler(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<DeleteResponse> Handle(DeleteRequest request, CancellationToken cancellationToken)
        {
            var deletedDepartment = await _departmentService.Detail(request.Id);
            var response = new DeleteResponse();

            if (deletedDepartment != null)
            {
                await _departmentService.Delete(deletedDepartment);
                response.IsDeleted = true;
                response.Message = "Department deleted";
            }
            else
            {
                response.IsDeleted = false;
                response.Message = "Department could not be deleted";
            }
            return response;
        }
    }
}
