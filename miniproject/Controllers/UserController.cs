using Application.Users.Commands.Create;
using Application.Users.Commands.Delete;
using Application.Users.Commands.Update;
using Application.Users.Queries.All;
using Application.Users.Queries.Detail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace miniproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateUserRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> Delete(DeleteUserRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Update(UpdateUserRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> All()
        {
            var request = new AllUserRequest();
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Detail([FromBody] DetailUserRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
