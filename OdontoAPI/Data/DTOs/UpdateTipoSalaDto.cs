using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs
{
    public class UpdateTipoSalaDto
    {
        [Required(ErrorMessage = "Descrição é um campo requerido")]
        public string Descricao { get; set; }
    }
}
