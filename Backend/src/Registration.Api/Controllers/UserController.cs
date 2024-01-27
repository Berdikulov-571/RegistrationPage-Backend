using MediatR;
using Microsoft.AspNetCore.Mvc;
using Registration.Domain.Entities.Users;
using Registration.Service.UseCases.Users.Commands;
using Registration.Service.UseCases.Users.Queries;

namespace Registration.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateUserCommand command)
        {
            int response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<User> users = await _mediator.Send(new GetAllUsersQuery());

            return Ok(users);
        }
    }
}