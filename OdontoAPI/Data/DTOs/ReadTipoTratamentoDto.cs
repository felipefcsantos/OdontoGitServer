using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class ReadTipoTratamentoDto
{
    public int IdTipoTratamento { get; set; }
    public string Descricao { get; set; }
    public Boolean Ativo { get; set; }
    public Double Valor { get; set; }
    public int TempoEstimado { get; set; }
    public DateTime HoraDataConsulta { get; set; } = DateTime.Now;
}
