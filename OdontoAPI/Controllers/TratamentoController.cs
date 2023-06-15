using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TratamentoController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public TratamentoController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaTratamento([FromBody] CreateTratamentoDto tratamentoDto)
    {
        Tratamento tratamento = _mapper.Map<Tratamento>(tratamentoDto);
        _context.Tratamentos.Add(tratamento);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaTratamento), new { id = tratamento.IdTratamento }, tratamento);
    }

    [HttpGet]
    public IEnumerable<ReadTratamentoDto> ListaTratamento([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadTratamentoDto>>(_context.Tratamentos.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult BuscaTratamento(int id)
    {

        var tratamento = _context.Tratamentos.FirstOrDefault(tratamento => tratamento.IdTratamento == id);
        if (tratamento == null)
        {
            return NotFound();
        }
        else
        {
            var tratamentoDto = _mapper.Map<ReadTratamentoDto>(tratamento);
            return Ok(tratamentoDto);
        }
    }
    


}
