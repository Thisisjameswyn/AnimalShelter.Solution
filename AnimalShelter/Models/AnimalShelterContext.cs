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
      builder.Entity<Animal>()
        .HasData(

          new Animal { AnimalId = 1, Name = "Test Name", Species = "Test Species", Age = 1, Gender = "Test Gender" },
          new Animal { AnimalId = 2, Name = "Vivian", Species = "Cat", Age = 12, Gender = "Female" },
          new Animal { AnimalId = 3, Name = "Claire", Species = "Dog", Age = 4, Gender = "Female Gender" },
          new Animal { AnimalId = 4, Name = "Marshal", Species = "Cat", Age = 1, Gender = "Male" },
          new Animal { AnimalId = 5, Name = "Bob", Species = "Chicken", Age = 1, Gender = "Female" },
          new Animal { AnimalId = 6, Name = "Not Bob", Species = "Chicken", Age = 1, Gender = "Female" }
        );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}