using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class ReadDentistaDto
{
    public int IdUsuario { get; set; }
    public string Cro { get; set; }
    public Boolean Segunda { get; set; }
    public Boolean Terceira { get; set; }
    public Boolean Quarta { get; set; }
    public Boolean Quinta { get; set; }
    public Boolean Sexta { get; set; }
    public Boolean Sabado { get; set; }
    public Boolean Domingo { get; set; }
    public Boolean Orcamento { get; set; }
    public Boolean Atendendo { get; set; }
}
