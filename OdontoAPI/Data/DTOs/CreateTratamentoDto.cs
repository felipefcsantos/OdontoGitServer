using OdontoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class CreateTratamentoDto
{
    [Required]
    public int IdTipoTratamento { get; set; }
}
