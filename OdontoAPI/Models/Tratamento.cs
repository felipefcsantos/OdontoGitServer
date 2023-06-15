using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Models;

public class Tratamento
{
    [Key]
    [Required]
    public int IdTratamento { get; set; }
    [Required]
    public int IdTipoTratamento { get; set; }
    public virtual TipoTratamento TipoTratamento { get; set; }

}
