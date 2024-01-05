using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp;

using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class Person
{
    public int PersonId { get; set; }
   
    public string Name { get; set; }
    
    public char Gender { get; set; }
    // Add other properties as needed
}

public class MyDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=bums.db");
    }
}
