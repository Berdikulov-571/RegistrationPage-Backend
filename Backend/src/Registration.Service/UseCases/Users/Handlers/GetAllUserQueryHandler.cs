using MediatR;
using Microsoft.EntityFrameworkCore;
using Registration.Domain.Entities.Users;
using Registration.Service.Abstractions.DbContexts;
using Registration.Service.UseCases.Users.Queries;

namespace Registration.Service.UseCases.Users.Handlers
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllUserQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<User>? users = await _context.Users.ToListAsync(cancellationToken);

            return users;
        }
    }
}