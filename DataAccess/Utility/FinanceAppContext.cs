using System;
using FinanceApp.Models.Entities;
using FinanceApp.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.DataAccess.Utility
{
  public class FinanceAppContext : DbContext
  {
    public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options) { }

    public DbSet<TypeEntity> Types { get; set; }
    public DbSet<InputTemplateEntity> InputTemplates { get; set; }
    public DbSet<InputEntity> Inputs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      var now = DateTime.UtcNow;
      foreach (var type in EnumUtil.GetValues<TypeEnum>())
      {
        modelBuilder.Entity<TypeEntity>().HasData(
          new TypeEntity()
          {
            Id = (int)type,
            CreatorId = 1,
            DateCreated = now,
            Description = EnumUtil.GetEnumDescription(type),
          }
        );
      }
    }
  }
}