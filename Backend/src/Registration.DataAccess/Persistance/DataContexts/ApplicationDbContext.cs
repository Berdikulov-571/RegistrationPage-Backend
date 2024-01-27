using Microsoft.EntityFrameworkCore;
using Registration.Domain.Entities.Users;
using Registration.Service.Abstractions.DbContexts;

namespace Registration.DataAccess.Persistance.DataContexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}