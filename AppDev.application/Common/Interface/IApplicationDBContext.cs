using AppDev.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppDev.Application.Common.Interface
{
    public interface IApplicationDBContext
    {
        DbSet<Employee> Employee { get; set; }
    }
}
