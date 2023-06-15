using OdontoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class UpdateTratamentoDto
{
    [Required]
    public int IdTipoTratamento { get; set; }
}
