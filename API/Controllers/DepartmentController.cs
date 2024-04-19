using Application.Department.Commands.Create;
using Application.Department.Commands.Delete;
using Application.Department.Commands.Update;
using Application.Department.Queries.All;
using Application.Department.Queries.Detail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace miniproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _medaitor;

        public DepartmentController(IMediator medaitor)
        {
            _medaitor = medaitor;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateRequest request)
        {
            var result = await _medaitor.Send(request);
            return Ok(result);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> Delete(DeleteRequest request)
        {
            var result = await _medaitor.Send(request);
            return Ok(result);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update(UpdateRequest request)
        {
            var result = await _medaitor.Send(request);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var request = new AllRequest();
            var departments = await _medaitor.Send(request);
            return Ok(departments);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Detail([FromBody] DetailRequest request)
        {
            var query = new DetailRequest 
            {
                Id = request.Id
            };

            var user = await _medaitor.Send(query);
            return Ok(user);
        }
    }
}
