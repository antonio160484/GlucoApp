using System.ComponentModel.DataAnnotations;

namespace GlucoApp.Web.Models;

public class MedicionGlucosa
{
    public int Id { get; set; }

    [Required]
    [StringLength(450)]
    public string UsuarioId { get; set; } = string.Empty;

    public UsuarioAplicacion Usuario { get; set; } = null!;

    [Range(typeof(decimal), "0.01", "99999.99")]
    public decimal Valor { get; set; }

    [EnumDataType(typeof(UnidadGlucosa))]
    public UnidadGlucosa Unidad { get; set; }

    [FechaNoFutura]
    public DateTimeOffset FechaHoraMedicion { get; set; }

    [EnumDataType(typeof(ContextoMedicion))]
    public ContextoMedicion? Contexto { get; set; }

    [StringLength(500)]
    public string? Nota { get; set; }
}
