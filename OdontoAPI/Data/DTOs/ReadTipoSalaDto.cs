using OdontoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs
{
    public class ReadTipoSalaDto
    {
        public int IdTipoSala { get; set; }
        public string Descricao { get; set; }
        public DateTime HoraDataConsulta { get; set; } = DateTime.Now;
        public ICollection<Sala> Salas { get; set; }
    }
}
