using GlucoApp.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlucoApp.Web.Data.Configuraciones;

public class ConfiguracionRegistroInsulina : IEntityTypeConfiguration<RegistroInsulina>
{
    public void Configure(EntityTypeBuilder<RegistroInsulina> constructor)
    {
        constructor.ToTable("RegistrosInsulina", tabla =>
            tabla.HasCheckConstraint(
                "CK_RegistrosInsulina_CantidadUnidades_Positiva",
                "[CantidadUnidades] > 0"));

        constructor.HasKey(registro => registro.Id);

        constructor.Property(registro => registro.UsuarioId)
            .HasMaxLength(450)
            .IsRequired();

        constructor.Property(registro => registro.CantidadUnidades)
            .HasPrecision(7, 2)
            .IsRequired();

        constructor.Property(registro => registro.FechaHoraAplicacion)
            .IsRequired();

        constructor.Property(registro => registro.NombreInsulina)
            .HasMaxLength(100);

        constructor.Property(registro => registro.Nota)
            .HasMaxLength(500);

        constructor.HasOne(registro => registro.Usuario)
            .WithMany(usuario => usuario.RegistrosInsulina)
            .HasForeignKey(registro => registro.UsuarioId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        constructor.HasIndex(registro => new { registro.UsuarioId, registro.FechaHoraAplicacion })
            .HasDatabaseName("IX_RegistrosInsulina_UsuarioId_FechaHoraAplicacion");
    }
}
