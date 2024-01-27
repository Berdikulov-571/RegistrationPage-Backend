using Microsoft.EntityFrameworkCore;
using Registration.Domain.Entities.Users;

namespace Registration.Service.Abstractions.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}