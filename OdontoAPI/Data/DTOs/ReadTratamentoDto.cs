using OdontoAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class ReadTratamentoDto
{
    public int IdTratamento { get; set; }
    public int IdTipoTratamento { get; set; }
    public DateTime HoraDataConsulta { get; set; } = DateTime.Now;
    public TipoTratamento TipoTratamento { get; set; }
}
