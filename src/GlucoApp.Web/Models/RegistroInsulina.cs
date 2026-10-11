using System.ComponentModel.DataAnnotations;

namespace GlucoApp.Web.Models;

public class RegistroInsulina
{
    public int Id { get; set; }

    [Required]
    [StringLength(450)]
    public string UsuarioId { get; set; } = string.Empty;

    public UsuarioAplicacion Usuario { get; set; } = null!;

    [Range(typeof(decimal), "0.01", "99999.99")]
    public decimal CantidadUnidades { get; set; }

    [FechaNoFutura]
    public DateTimeOffset FechaHoraAplicacion { get; set; }

    [StringLength(100)]
    public string? NombreInsulina { get; set; }

    [StringLength(500)]
    public string? Nota { get; set; }
}
