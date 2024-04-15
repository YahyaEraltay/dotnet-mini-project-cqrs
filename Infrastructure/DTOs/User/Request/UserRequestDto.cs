using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTOs.User.Request
{
    public class UserRequestDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
