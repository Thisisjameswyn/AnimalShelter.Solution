using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>()
        .HasData(

          new Animal { AnimalId = 1, Name = "Test Name", Species = "Test Species", Age = 1, Gender = "Test Gender" }
        );
    }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Message> Messages { get; set; }
  }
}