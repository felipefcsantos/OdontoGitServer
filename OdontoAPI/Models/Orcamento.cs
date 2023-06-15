using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Models;

public class Orcamento
{
    [Key]
    [Required]
    public int IdOrcamento { get; set; }
    [Required(ErrorMessage = "Desconto é um campo requerido")]
    public Double Desconto { get; set; }
    [Required(ErrorMessage = "Status é um campo requerido")]
    public Boolean Status { get; set; }
    

}
