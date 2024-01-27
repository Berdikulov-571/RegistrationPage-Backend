using MediatR;
using Registration.Domain.Dtos.Users;

namespace Registration.Service.UseCases.Users.Commands
{
    public class CreateUserCommand : UserRegistration, IRequest<int>
    {

    }
}