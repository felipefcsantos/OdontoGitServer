using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TipoTratamentoController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public TipoTratamentoController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaTipoTratamento([FromBody] CreateTipoTratamentoDto tipoTratamentoDto)
    {
        TipoTratamento tipoTratamento = _mapper.Map<TipoTratamento>(tipoTratamentoDto);
        _context.TipoTratamentos.Add(tipoTratamento);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaTipoTratamento), new { id = tipoTratamento.IdTipoTratamento }, tipoTratamento);
    }

    [HttpGet]
    public IEnumerable<ReadTipoTratamentoDto> ListaTipoTratamento([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadTipoTratamentoDto>>(_context.TipoTratamentos.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult BuscaTipoTratamento(int id)
    {

        var tipotratamento = _context.TipoTratamentos.FirstOrDefault(tipoTratamento => tipoTratamento.IdTipoTratamento == id);
        if (tipotratamento == null)
        {
            return NotFound();
        }
        else
        {
            var tipoTratamentoDto = _mapper.Map<ReadTipoTratamentoDto>(tipotratamento);
            return Ok(tipoTratamentoDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtivaDesativaPutTipoTratamento(int id, UpdateTipoTratamentoDto tipoTratamentoDto)
    {
        var tipotratamento = _context.TipoTratamentos.FirstOrDefault(tipoTratamento => tipoTratamento.IdTipoTratamento == id);
        if (tipotratamento == null)
        {
            return NotFound();
        }
        else
        {
            tipotratamento.Ativo = tipoTratamentoDto.Ativo;
            _context.SaveChanges();
            return NoContent();
        }
    }


}
