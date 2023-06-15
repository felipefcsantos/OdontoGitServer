using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs
{
    public class CreateTipoSalaDto
    {
        [Required(ErrorMessage = "Descrição é um campo requerido")]
        public string Descricao { get; set; }
    }
}
