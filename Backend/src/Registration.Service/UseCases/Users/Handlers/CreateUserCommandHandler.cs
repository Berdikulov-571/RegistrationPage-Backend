using MediatR;
using Microsoft.EntityFrameworkCore;
using Registration.Domain.Entities.Users;
using Registration.Domain.Exeptions.Email;
using Registration.Domain.Exeptions.PhoneNumber;
using Registration.Service.Abstractions.DbContexts;
using Registration.Service.Security.PasswordHash;
using Registration.Service.UseCases.Users.Commands;

namespace Registration.Service.UseCases.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User? checkPhoneNumber = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber, cancellationToken);

            User? checkEmail = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken);

            if (checkPhoneNumber != null)
                throw new PhoneNumberAlreadyExists();
            else if (checkEmail != null)
                throw new EmailAlreadyExists();

            User user = new User()
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                PasswordHash = Hash512.ComputeSHA512HashFromString(request.Password),
            };

            await _context.Users.AddAsync(user, cancellationToken);
            int result = await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}