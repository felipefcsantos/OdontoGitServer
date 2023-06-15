using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class UpdateTipoTratamentoDto
{
    [Required(ErrorMessage = "Descrição é um campo requerido")]
    [MaxLength(250, ErrorMessage = "Descrição deve conter até 250 caracteres")]
    public string Descricao { get; set; }
    [Required(ErrorMessage = "Ativo é um campo requerido")]
    public Boolean Ativo { get; set; }
    [Required(ErrorMessage = "Valor é um campo requerido")]
    public Double Valor { get; set; }
    [Required(ErrorMessage = "Tempo estimado é um campo requerido")]
    public int TempoEstimado { get; set; }
}
