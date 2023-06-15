using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DentistaController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public DentistaController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaDentista([FromBody] CreateDentistaDto dentistaDto)
    {
        Dentista dentista = _mapper.Map<Dentista>(dentistaDto);
        _context.Dentistas.Add(dentista);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaDentista), new { id = dentista.IdUsuario }, dentista);
    }

    [HttpGet]
    public IEnumerable<ReadDentistaDto> ListaDentista([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadDentistaDto>>(_context.Dentistas.Skip(skip).Take(take));
    }
    [HttpGet("{id}")]
    public IActionResult BuscaDentista(int id)
    {

        var dentista = _context.Dentistas.FirstOrDefault(Dentista => Dentista.IdUsuario == id);
        if (dentista == null)
        {
            return NotFound();
        }
        else
        {
            var dentistaDto = _mapper.Map<ReadDentistaDto>(dentista);
            return Ok(dentistaDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtualizaPutDentista(int id, UpdateDentistaDto dentistaDto)
    {
        var dentista = _context.Dentistas.FirstOrDefault(Dentista => Dentista.IdUsuario == id);
        if (dentista == null)
        {
            return NotFound();
        }
        else
        {
            _mapper.Map(dentistaDto, dentista);
            _context.SaveChanges();
            return NoContent();
        }
    }
    [HttpDelete("{id}")]
    public IActionResult DeletaDentista(int id)
    {
        var dentista = _context.Dentistas.FirstOrDefault(Dentista => Dentista.IdUsuario == id);
        if (dentista == null)
        {
            return NotFound();
        }
        else
        {
            _context.Remove(dentista);
            _context.SaveChanges();
            return NoContent();
        }
    }
    [HttpPatch("{id}")]
    public IActionResult AtualizaPacthDentista(int id, JsonPatchDocument<UpdateDentistaDto> patch)
    {
        var dentista = _context.Dentistas.FirstOrDefault(Dentista => Dentista.IdUsuario == id);
        if (dentista == null)
        {
            return NotFound();
        }
        else
        {
            var dentistaParaAtualizar = _mapper.Map<UpdateDentistaDto>(dentista);
            patch.ApplyTo(dentistaParaAtualizar, ModelState);

            if (!TryValidateModel(ModelState))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(dentistaParaAtualizar, dentista);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
