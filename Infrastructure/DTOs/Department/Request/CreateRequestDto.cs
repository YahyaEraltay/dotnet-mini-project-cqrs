using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTOs.Department.Request
{
    public class CreateRequestDto
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
    }
}
