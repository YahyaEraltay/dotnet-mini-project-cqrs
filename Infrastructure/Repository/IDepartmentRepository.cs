using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IDepartmentRepository
    {
        Task<Department> Create(Department department);
        Task<Department> Update(Department department);
        Task<Department> Delete(Department department);
        Task<List<Department>> GetAll();
        Task<Department> Detail(Guid id);
    }
}
