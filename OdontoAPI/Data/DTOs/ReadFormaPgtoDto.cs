using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class ReadFormaPgtoDto
{

    public int IdFormaDePagamento { get; set; }
    public string Metodo { get; set; }
    public Boolean Ativo { get; set; }
    public Double Taxa { get; set; }
    public DateTime HoraDataConsulta { get; set; } = DateTime.Now;
    public ICollection<ReadPagamentoDto> Pagamentos { get; set; }

}
