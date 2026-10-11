using Microsoft.AspNetCore.Identity;

namespace GlucoApp.Web.Models;

public class UsuarioAplicacion : IdentityUser
{
    public ICollection<MedicionGlucosa> MedicionesGlucosa { get; set; } = new List<MedicionGlucosa>();

    public ICollection<RegistroInsulina> RegistrosInsulina { get; set; } = new List<RegistroInsulina>();
}
