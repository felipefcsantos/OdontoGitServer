using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PagamentoController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public PagamentoController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaPagamento([FromBody] CreatePagamentoDto pagamentoDto)
    {
        Pagamento pagamento = _mapper.Map<Pagamento>(pagamentoDto);
        _context.Pagamentos.Add(pagamento);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaPagamento), new { id = pagamento.IdPagamento }, pagamento);
    }

    [HttpGet]
    public IEnumerable<ReadPagamentoDto> ListaPagamento([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadPagamentoDto>>(_context.Pagamentos.Skip(skip).Take(take));
    }

        [HttpGet("{id}")]
    public IActionResult BuscaPagamento(int id)
    {

        var pagamento = _context.Pagamentos.FirstOrDefault(Pagamento => Pagamento.IdPagamento == id);
        if (pagamento == null)
        {
            return NotFound();
        }
        else
        {
            var PagamentoDto = _mapper.Map<ReadPagamentoDto>(pagamento);
            return Ok(PagamentoDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtualizaPagamento(int id, UpdatePagamentoDto PagamentoDto)
    {
        var pagamento = _context.Pagamentos.FirstOrDefault(Pagamento => Pagamento.IdPagamento == id);
        if (pagamento == null)
        {
            return NotFound();
        }
        else
        {
            _mapper.Map(PagamentoDto, pagamento);
            _context.SaveChanges();
            return NoContent();
        }
    }
    [HttpDelete("{id}")]
    public IActionResult DeletaPagamento(int id)
    {
        var pagamento = _context.Pagamentos.FirstOrDefault(Pagamento => Pagamento.IdPagamento == id);
        if (pagamento == null)
        {
            return NotFound();
        }
        else
        {
            _context.Remove(pagamento);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
