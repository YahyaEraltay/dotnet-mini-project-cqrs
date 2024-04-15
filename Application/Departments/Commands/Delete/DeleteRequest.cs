using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Department.Commands.Delete
{
    public class DeleteRequest : IRequest<DeleteResponse>
    {
        public Guid Id { get; set; }
    }
}
