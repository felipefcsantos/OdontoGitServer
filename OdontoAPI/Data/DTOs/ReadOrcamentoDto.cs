using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class ReadOrcamentoDto
{


    public int IdOrcamento { get; set; }
    public Double Desconto { get; set; }
    public Boolean Status { get; set; }


}
