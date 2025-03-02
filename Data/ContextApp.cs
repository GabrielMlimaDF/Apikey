using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class ContextApp : DbContext
{
    public ContextApp(DbContextOptions options) : base(options)
    {
    }

    //public DbSet<T> T { get; set; }
    //public DbSet<T> T { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new TMap());
        //modelBuilder.ApplyConfiguration(new Tmap());

    }

}