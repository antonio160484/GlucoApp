using GlucoApp.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlucoApp.Web.Data.Configuraciones;

public class ConfiguracionMedicionGlucosa : IEntityTypeConfiguration<MedicionGlucosa>
{
    public void Configure(EntityTypeBuilder<MedicionGlucosa> constructor)
    {
        constructor.ToTable("MedicionesGlucosa", tabla =>
            tabla.HasCheckConstraint(
                "CK_MedicionesGlucosa_Valor_Positivo",
                "[Valor] > 0"));

        constructor.HasKey(medicion => medicion.Id);

        constructor.Property(medicion => medicion.UsuarioId)
            .HasMaxLength(450)
            .IsRequired();

        constructor.Property(medicion => medicion.Valor)
            .HasPrecision(7, 2)
            .IsRequired();

        constructor.Property(medicion => medicion.Unidad)
            .HasConversion<string>()
            .HasMaxLength(30)
            .IsRequired();

        constructor.Property(medicion => medicion.FechaHoraMedicion)
            .IsRequired();

        constructor.Property(medicion => medicion.Contexto)
            .HasConversion<string>()
            .HasMaxLength(30);

        constructor.Property(medicion => medicion.Nota)
            .HasMaxLength(500);

        constructor.HasOne(medicion => medicion.Usuario)
            .WithMany(usuario => usuario.MedicionesGlucosa)
            .HasForeignKey(medicion => medicion.UsuarioId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        constructor.HasIndex(medicion => new { medicion.UsuarioId, medicion.FechaHoraMedicion })
            .HasDatabaseName("IX_MedicionesGlucosa_UsuarioId_FechaHoraMedicion");
    }
}
