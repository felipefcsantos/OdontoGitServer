using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs
{
    public class CreateSalaDto
    {
        
        [Required(ErrorMessage = "NomeSala é um campo requerido")]
        public string NomeSala { get; set; }
        [Required(ErrorMessage = "Ativo é um campo requerido")]
        public Boolean Ativo { get; set; }
    }
}
