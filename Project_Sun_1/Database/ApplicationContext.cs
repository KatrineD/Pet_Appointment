using Microsoft.EntityFrameworkCore;
using Project_Sun_1.Models;

// Класс для описания всех моделей, которые должны быть в базе
public class ApplicationContext: DbContext
{
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<MedicalReport> Documents { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
    {
        Database.EnsureCreated();
    }
}