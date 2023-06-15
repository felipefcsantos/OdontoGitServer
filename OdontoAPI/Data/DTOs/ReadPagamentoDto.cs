using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class ReadPagamentoDto
{

    public int IdPagamento { get; set; }
    public Double Valor { get; set; }
    public int IdFormaDePagamento { get; set; }
    public DateTime HoraDataConsulta { get; set; } = DateTime.Now;


}
