using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Models;

public class FormaPgto
{
    [Key]
    [Required]
    public int IdFormaDePagamento { get; set; }
    [Required (ErrorMessage = "Método é um campo requerido")]
    [MaxLength (50, ErrorMessage = "Método deve conter até 50 caracteres")]
    public string Metodo { get; set; }
    [Required(ErrorMessage = "Ativo é um campo requerido")]
    public Boolean Ativo { get; set; }
    [Required(ErrorMessage = "Taxa é um campo requerido")]
    public Double Taxa { get; set; }
    public virtual ICollection<Pagamento> Pagamentos { get; set; }

}
