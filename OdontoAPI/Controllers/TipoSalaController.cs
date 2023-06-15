using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TipoSalaController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public TipoSalaController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaTipoSala([FromBody] CreateTipoSalaDto tipoSalaDto)
    {
        TipoSala tipoSala = _mapper.Map<TipoSala>(tipoSalaDto);
        _context.TipoSalas.Add(tipoSala);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaTipoSala), new { id = tipoSala.IdTipoSala }, tipoSala);
    }

    [HttpGet]
    public IEnumerable<ReadTipoSalaDto> ListaTipoSala([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadTipoSalaDto>>(_context.TipoSalas.Skip(skip).Take(take));
    }
  
    [HttpGet("{id}")]
    public IActionResult BuscaTipoSala(int id)
    {

        var tiposala = _context.TipoSalas.FirstOrDefault(tipoSala => tipoSala.IdTipoSala == id);
        if (tiposala == null)
        {
            return NotFound();
        }
        else
        {
            var tipoSalaDto = _mapper.Map<ReadTipoSalaDto>(tiposala);
            return Ok(tipoSalaDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtualizaTipoSala(int id, UpdateTipoSalaDto tipoSalaDto)
    {
        var tiposala = _context.TipoSalas.FirstOrDefault(tipoSala => tipoSala.IdTipoSala == id);
        if (tiposala == null)
        {
            return NotFound();
        }
        else
        {
            _mapper.Map(tipoSalaDto, tiposala);
            _context.SaveChanges();
            return NoContent();
        }
    }
    [HttpDelete("{id}")]
    public IActionResult DeletaTipoSala(int id)
    {
        var tiposala = _context.TipoSalas.FirstOrDefault(tipoSala => tipoSala.IdTipoSala == id);
        if (tiposala == null)
        {
            return NotFound();
        }
        else
        {
            _context.Remove(tiposala);
            _context.SaveChanges();
            return NoContent();
        }
    }

}
