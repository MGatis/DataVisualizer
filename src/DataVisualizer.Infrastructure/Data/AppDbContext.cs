using DataVisualizer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataVisualizer.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Vacancy> Vacancies => Set<Vacancy>();
    public DbSet<ImportRun> ImportRuns => Set<ImportRun>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Vacancy>(e =>
        {
            e.HasIndex(x => x.VacancyNumber).IsUnique();
            e.HasIndex(x => x.Category);
            e.HasIndex(x => x.ApplicationDeadline);

            e.Property(x => x.VacancyNumber).HasMaxLength(30);
            e.Property(x => x.EmployerRegistrationNumber).HasMaxLength(20);
            e.Property(x => x.Title).HasMaxLength(300);
            e.Property(x => x.Category).HasMaxLength(200);
            e.Property(x => x.WorkloadType).HasMaxLength(100);
            e.Property(x => x.WorkTimeType).HasMaxLength(100);
            e.Property(x => x.Location).HasMaxLength(500);
            e.Property(x => x.ImageUrl).HasMaxLength(1000);
            e.Property(x => x.DetailsUrl).HasMaxLength(1000);
            e.Property(x => x.SalaryFrom).HasPrecision(10, 2);
            e.Property(x => x.SalaryTo).HasPrecision(10, 2);
            e.Property(x => x.HoursPerWeek).HasPrecision(5, 2);
        });

        b.Entity<ImportRun>(e =>
        {
            e.Property(x => x.Source).HasMaxLength(100);
            e.Property(x => x.Status).HasMaxLength(20);
            e.HasIndex(x => new { x.Source, x.StartedAt });
        });
    }
}