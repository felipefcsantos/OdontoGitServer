using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Models;

public class TipoTratamento
{
    [Key]
    [Required]
    public int IdTipoTratamento { get; set; }
    [Required (ErrorMessage = "Descrição é um campo requerido")]
    [MaxLength (250, ErrorMessage = "Descrição deve conter até 250 caracteres")]
    public string Descricao { get; set; }
    [Required(ErrorMessage = "Ativo é um campo requerido")]
    public Boolean Ativo { get; set; }
    [Required(ErrorMessage = "Valor é um campo requerido")]
    public Double Valor { get; set; }
    [Required(ErrorMessage = "Tempo estimado é um campo requerido")]
    public int TempoEstimado { get; set; }
    public virtual ICollection<Tratamento> Tratamentos { get; set; }

}
