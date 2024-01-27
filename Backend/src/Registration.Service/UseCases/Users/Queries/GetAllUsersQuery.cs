using MediatR;
using Registration.Domain.Entities.Users;

namespace Registration.Service.UseCases.Users.Queries
{
    public class GetAllUsersQuery : IRequest<IEnumerable<User>>
    {

    }
}