using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class CreateEnderecoDto
{


    [Required(ErrorMessage = "Cep é um campo requerido")]
    [MaxLength(8, ErrorMessage = "Cep deve conter 8 caracteres")]
    public string Cep { get; set; }
    [Required(ErrorMessage = "Logradouro é um campo requerido")]
    [MaxLength(100, ErrorMessage = "Logradouro deve conter até 100 caracteres")]
    public string Logradouro { get; set; }
    [Required(ErrorMessage = "Número é um campo requerido")]
    [MaxLength(8, ErrorMessage = "Número deve conter até 8 caracteres")]
    public string Numero { get; set; }
    [Required(ErrorMessage = "Complemento é um campo requerido")]
    [MaxLength(10, ErrorMessage = "Complemento deve conter até 10 caracteres")]
    public string Complemento { get; set; }
    [Required(ErrorMessage = "Bairro é um campo requerido")]
    [MaxLength(30, ErrorMessage = "Bairro deve conter até 30 caracteres")]
    public string Bairro { get; set; }
    [Required(ErrorMessage = "Cidade é um campo requerido")]
    [MaxLength(30, ErrorMessage = "Cidade deve conter até 30 caracteres")]
    public string Cidade { get; set; }
    [Required(ErrorMessage = "Uf é um campo requerido")]
    [MaxLength(2, ErrorMessage = "Uf deve conter 2 caracteres")]
    public string Uf { get; set; }


}
