using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OrcamentoController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public OrcamentoController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaOrcamento([FromBody] CreateOrcamentoDto orcamentoDto)
    {
        Orcamento orcamento = _mapper.Map<Orcamento>(orcamentoDto);
        _context.Orcamentos.Add(orcamento);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaOrcamento), new { id = orcamento.IdOrcamento }, orcamento);
    }

    [HttpGet]
    public IEnumerable<ReadOrcamentoDto> ListaOrcamento([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadOrcamentoDto>>(_context.Orcamentos.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult BuscaOrcamento(int id)
    {

        var orcamento = _context.Orcamentos.FirstOrDefault(Orcamento => Orcamento.IdOrcamento == id);
        if (orcamento == null)
        {
            return NotFound();
        }
        else
        {
            var orcamentoDto = _mapper.Map<ReadOrcamentoDto>(orcamento);
            return Ok(orcamentoDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtualizaOrcamento(int id, UpdateOrcamentoDto orcamentoDto)
    {
        var orcamento = _context.Orcamentos.FirstOrDefault(Orcamento => Orcamento.IdOrcamento == id);
        if (orcamento == null)
        {
            return NotFound();
        }
        else
        {
            _mapper.Map(orcamentoDto, orcamento);
            _context.SaveChanges();
            return NoContent();
        }
    }
    [HttpDelete("{id}")]
    public IActionResult DeletaOrcamento(int id)
    {
        var orcamento = _context.Orcamentos.FirstOrDefault(Orcamento => Orcamento.IdOrcamento == id);
        if (orcamento == null)
        {
            return NotFound();
        }
        else
        {
            _context.Remove(orcamento);
            _context.SaveChanges();
            return NoContent();
        }
    }



}
