using Domain.Entities;
using Infrastructure.DTOs.Department.Request;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<Department> Create(CreateRequestDto request)
        {
            var department = new Department()
            {
                DepartmentName = request.DepartmentName,
                DepartmentDescription = request.DepartmentDescription
            };

            await _departmentRepository.Create(department);
            return department;
        }

        public async Task<Department> Delete(Department department)
        {
            var deletedDepartment = await _departmentRepository.Detail(department.Id);
           
            await _departmentRepository.Delete(deletedDepartment);
            return deletedDepartment;
        }

        public async Task<Department> Detail(Guid id)
        {
            return await _departmentRepository.Detail(id);
        }

        public async Task<List<Department>> GetAll()
        {
            return await _departmentRepository.GetAll();
        }

        public async Task<Department> Update(Department department)
        {
            return await _departmentRepository.Update(department);
        }
    }
}
