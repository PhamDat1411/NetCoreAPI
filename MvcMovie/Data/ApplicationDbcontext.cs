
using Microsoft.EntityFrameworkCore;
using MvcMovie.Controllers;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee { get; set;}
        public DbSet<DaiLy> DaiLy { get; set;}
        
    }
}