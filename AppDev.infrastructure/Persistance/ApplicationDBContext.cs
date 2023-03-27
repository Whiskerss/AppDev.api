using AppDev.Application.Common.Interface;
using AppDev.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AppDev.Infrastructure.Persistance
{
    // public class ApplicationDBContext : DbContext, IApplicationDBContext

    public class ApplicationDBContext : IdentityDbContext<IdentityUser, IdentityRole, string>, IApplicationDBContext
    {
        private readonly IDateTime _dateTime;

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options,IDateTime dateTime) :base(options)
            {
            _dateTime = dateTime;
            }

        public DbSet<Employee> Employee { get; set; }
    }
}
