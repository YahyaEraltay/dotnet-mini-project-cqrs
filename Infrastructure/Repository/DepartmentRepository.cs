using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Department> Create(Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<Department> Delete(Department department)
        {
            var deletedDepartment = await _context.Departments.FirstOrDefaultAsync(x => x.Id == department.Id);

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            
            return department;
        }

        public async Task<Department> Detail(Guid id)
        {
            var department = await _context.Departments.FirstOrDefaultAsync(x => x.Id == id);
            return department;
        }

        public Task<List<Department>> GetAll()
        {
            return _context.Departments.ToListAsync();
        }

        public async Task<Department> Update(Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
            return department;
        }
    }
}
