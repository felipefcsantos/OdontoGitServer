using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FormaPgtoController : ControllerBase
{

    private FormaPgtoContext _context;
    private IMapper _mapper;

    public FormaPgtoController(FormaPgtoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaFormaPgto([FromBody] CreateFormaPgtoDto formaPgtoDto)
    {
        FormaPgto formaPgto = _mapper.Map<FormaPgto>(formaPgtoDto);
        _context.FormasPgtos.Add(formaPgto);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaFormaPgto), new { id = formaPgto.IdFormaDePagamento }, formaPgto);
    }

    [HttpGet]
    public IEnumerable<FormaPgto> ListaFormaPgto([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.FormasPgtos.Skip(skip).Take(take);
    }
    [HttpGet("{id}")]
    public IActionResult BuscaFormaPgto(int id)
    {

        var formapgto = _context.FormasPgtos.FirstOrDefault(formaPgto => formaPgto.IdFormaDePagamento == id);
        if (formapgto == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(formapgto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtivaDesativaFormaPgto(int id, [FromBody] UpdateFormaPgtoDto formaPgtoDto)
    {
        var formapgto = _context.FormasPgtos.FirstOrDefault(formaPgto => formaPgto.IdFormaDePagamento == id);
        if (formapgto == null)
        {
            return NotFound();
        }
        else
        {
            formapgto.Ativo = formaPgtoDto.Ativo;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
