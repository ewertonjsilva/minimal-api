namespace MinimalApi.DTOs;

public class LoginDTO
{
    // default porque a propriedade é obrigatória
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
}

