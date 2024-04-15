using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Department.Commands.Create
{
    public class CreateRequest : IRequest<CreateResponse>
    {
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
    }
}
