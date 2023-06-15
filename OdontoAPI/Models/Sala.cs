using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Models;

public class Sala
{
    [Key]
    [Required]
    public int IdSala { get; set; }
    [Required(ErrorMessage = "NomeSala é um campo requerido")]
    public string NomeSala { get; set; }
    [Required(ErrorMessage = "Ativo é um campo requerido")]
    public Boolean Ativo { get; set; }
    [Required]
    public int IdTipoSala { get; set; }
    public virtual TipoSala TipoSala { get; set; }

}
