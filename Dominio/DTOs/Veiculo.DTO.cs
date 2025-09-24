using Microsoft.EntityFrameworkCore;

namespace MinimalApi.DTOs;

public record VeiculoDTO
{
    // default porque a propriedade é obrigatória
    public string Nome { get; set; } = default!;
    public string Marca { get; set; } = default!;
    public int Ano { get; set; } = default!;
}

