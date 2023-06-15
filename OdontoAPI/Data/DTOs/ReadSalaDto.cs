using OdontoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs
{
    public class ReadSalaDto
    {
        public int IdSala { get; set; }
        public string NomeSala { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime HoraDataConsulta { get; set; } = DateTime.Now;
        public TipoSala TipoSala { get; set; }
    }
}
