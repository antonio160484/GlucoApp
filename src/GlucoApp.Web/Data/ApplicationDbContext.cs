using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GlucoApp.Web.Data.Configuraciones;
using GlucoApp.Web.Models;

namespace GlucoApp.Web.Data;

public class ApplicationDbContext : IdentityDbContext<UsuarioAplicacion>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<MedicionGlucosa> MedicionesGlucosa => Set<MedicionGlucosa>();

    public DbSet<RegistroInsulina> RegistrosInsulina => Set<RegistroInsulina>();

    protected override void OnModelCreating(ModelBuilder constructor)
    {
        base.OnModelCreating(constructor);

        constructor.ApplyConfiguration(new ConfiguracionMedicionGlucosa());
        constructor.ApplyConfiguration(new ConfiguracionRegistroInsulina());
    }
}
