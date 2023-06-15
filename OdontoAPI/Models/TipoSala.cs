using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Models;

public class TipoSala
{
    [Key]
    [Required]
    public int IdTipoSala { get; set; }
    [Required(ErrorMessage = "Descrição é um campo requerido")]
    public string Descricao { get; set; }
    public virtual ICollection<Sala> Salas { get; set; }

}
