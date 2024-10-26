// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using SimpleMvcApp.Models;

namespace SimpleMvcApp.Data{


public class AppDbContext : DbContext
{
    public DbSet<UserInput> UserInputs { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}

}

