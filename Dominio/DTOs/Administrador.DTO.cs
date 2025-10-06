using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Enuns;

namespace MinimalApi.DTOs;

public class AdministradorDTO : DbContext
{
    // default porque a propriedade é obrigatória
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
    public Perfil? Perfil { get; set; } = default!;
}

