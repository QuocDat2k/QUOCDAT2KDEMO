 
using Microsoft.EntityFrameworkCore;
using dotnet.Models;
namespace dotnet.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<Student> Student { get; set; }
        public DbSet<Product> khachHangs { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}