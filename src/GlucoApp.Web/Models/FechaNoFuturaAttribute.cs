using System.ComponentModel.DataAnnotations;

namespace GlucoApp.Web.Models;

[AttributeUsage(AttributeTargets.Property)]
public sealed class FechaNoFuturaAttribute : ValidationAttribute
{
    public FechaNoFuturaAttribute()
        : base("La fecha y hora no puede ser futura.")
    {
    }

    public override bool IsValid(object? valor)
    {
        return valor is DateTimeOffset fechaHora &&
               fechaHora != default &&
               fechaHora <= DateTimeOffset.UtcNow;
    }
}
