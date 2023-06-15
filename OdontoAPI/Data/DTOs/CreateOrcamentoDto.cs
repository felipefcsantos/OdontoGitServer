using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class CreateOrcamentoDto
{


    [Required(ErrorMessage = "Desconto é um campo requerido")]
    public Double Desconto { get; set; }
    [Required(ErrorMessage = "Status é um campo requerido")]
    public Boolean Status { get; set; }


}
