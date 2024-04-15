using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Department.Queries.Detail
{
    public class DetailRequest : IRequest<DetailResponse>
    {
        public Guid Id { get; set; }
    }
}
