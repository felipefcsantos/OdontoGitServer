using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Models;

public class Pagamento
{
    [Key]
    [Required]
    public int IdPagamento { get; set; }
    [Required(ErrorMessage = "Valor é um campo requerido")]
    public Double Valor { get; set; }
    [Required]
    public int IdFormaDePagamento { get; set; }
    public virtual FormaPgto FormaPgto { get; set; }


}
