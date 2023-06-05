using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class CreateFormaPgtoDto
{

    
    [Required(ErrorMessage = "Método é um campo requerido")]
    [StringLength(50, ErrorMessage = "Método deve conter até 50 caracteres")]
    public string Metodo { get; set; }
    [Required(ErrorMessage = "Ativo é um campo requerido")]
    public Boolean Ativo { get; set; }
    [Required(ErrorMessage = "Taxa é um campo requerido")]
    [Range(0,0.5, ErrorMessage = "Taxa deve ser entre 0.01 e 0.5")]
    public Double Taxa { get; set; }


}
