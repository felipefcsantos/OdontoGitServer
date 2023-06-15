using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SalaController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public SalaController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaSala([FromBody] CreateTipoSalaDto SalaDto)
    {
        Sala Sala = _mapper.Map<Sala>(SalaDto);
        _context.Salas.Add(Sala);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaSala), new { id = Sala.IdSala }, Sala);
    }

    [HttpGet]
    public IEnumerable<ReadSalaDto> ListaSala([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadSalaDto>>(_context.Salas.Skip(skip).Take(take));
    }
  
    [HttpGet("{id}")]
    public IActionResult BuscaSala(int id)
    {

        var sala = _context.Salas.FirstOrDefault(Sala => Sala.IdSala == id);
        if (sala == null)
        {
            return NotFound();
        }
        else
        {
            var SalaDto = _mapper.Map<ReadSalaDto>(sala);
            return Ok(SalaDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtualizaSala(int id, UpdateSalaDto SalaDto)
    {
        var sala = _context.Salas.FirstOrDefault(Sala => Sala.IdSala == id);
        if (sala == null)
        {
            return NotFound();
        }
        else
        {
            _mapper.Map(SalaDto, sala);
            _context.SaveChanges();
            return NoContent();
        }
    }
    [HttpDelete("{id}")]
    public IActionResult DeletaSala(int id)
    {
        var sala = _context.Salas.FirstOrDefault(Sala => Sala.IdSala == id);
        if (sala == null)
        {
            return NotFound();
        }
        else
        {
            _context.Remove(sala);
            _context.SaveChanges();
            return NoContent();
        }
    }

}
