#nullable enable
using CoreBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace Services;

    public partial class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

        public virtual DbSet<EmployeeModel> EmployeeModels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeModel>(entity =>
        {
            entity.ToTable("Employee");
            entity.HasKey("Id");
            entity.Property(e => e.Name);
            entity.Property(e => e.Email);
            entity.Property(e => e.Dob).HasColumnType("datetime");
            entity.Property(e => e.Salary).HasColumnType("float");
            entity.Property(e => e.Status).HasColumnType("bit");
            entity.Property(e => e.Designation);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        //{
        //    return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        //}
    }

