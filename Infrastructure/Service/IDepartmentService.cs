using Domain.Entities;
using Infrastructure.DTOs.Department.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public interface IDepartmentService
    {
        Task<Department> Create(CreateRequestDto request);
        Task<Department> Update(Department department);
        Task<Department> Delete(Department department);
        Task<List<Department>> GetAll();
        Task<Department> Detail(Guid id);

    }
}
