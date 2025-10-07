using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews;

public record AdministradorLogadoModelView
{
    public required string Email { get; set; }
    public required string Perfil { get; set; }
    public required string Token { get; set; }
}


