﻿using System.ComponentModel.DataAnnotations;

namespace OdontoAPI.Data.DTOs;

public class UpdatePagamentoDto
{


    [Required(ErrorMessage = "Valor é um campo requerido")]
    public Double Valor { get; set; }
    [Required]
    public int IdFormaDePagamento { get; set; }


}
