using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class CreateDentistaDto
{


    [Required(ErrorMessage = "Cro é um campo requerido")]
    [MaxLength(15, ErrorMessage = "Cro deve conter até 15 caracteres")]
    public string Cro { get; set; }
    [Required(ErrorMessage = "Segunda é um campo requerido")]
    public Boolean Segunda { get; set; }
    [Required(ErrorMessage = "Terceira é um campo requerido")]
    public Boolean Terceira { get; set; }
    [Required(ErrorMessage = "Quarta é um campo requerido")]
    public Boolean Quarta { get; set; }
    [Required(ErrorMessage = "Quinta é um campo requerido")]
    public Boolean Quinta { get; set; }
    [Required(ErrorMessage = "Sexta é um campo requerido")]
    public Boolean Sexta { get; set; }
    [Required(ErrorMessage = "Sábado é um campo requerido")]
    public Boolean Sabado { get; set; }
    [Required(ErrorMessage = "Domingo é um campo requerido")]
    public Boolean Domingo { get; set; }
    [Required(ErrorMessage = "Orçamento é um campo requerido")]
    public Boolean Orcamento { get; set; }
    [Required(ErrorMessage = "Atendendo é um campo requerido")]
    public Boolean Atendendo { get; set; }


}
