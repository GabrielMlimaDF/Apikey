using ApiKey.Data.Mapping;
using ApiKey.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class ContextApp : DbContext
{
    public ContextApp(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Category>  Categories { get; set; }
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryMap());
     
    }

}