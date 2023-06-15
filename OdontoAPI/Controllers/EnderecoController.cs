using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public EnderecoController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
    {
        Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
        _context.Enderecos.Add(endereco);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaEndereco), new { id = endereco.IdEndereco }, endereco);
    }

    [HttpGet]
    public IEnumerable<ReadEnderecoDto> ListaEndereco([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos.Skip(skip).Take(take));
    }
    [HttpGet("{id}")]
    public IActionResult BuscaEndereco(int id)
    {

        var endereco = _context.Enderecos.FirstOrDefault(Endereco => Endereco.IdEndereco == id);
        if (endereco == null)
        {
            return NotFound();
        }
        else
        {
            var enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
            return Ok(enderecoDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtualizaEndereco(int id, UpdateEnderecoDto enderecoDto)
    {
        var endereco = _context.Enderecos.FirstOrDefault(Endereco => Endereco.IdEndereco == id);
        if (endereco == null)
        {
            return NotFound();
        }
        else
        {
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }
    }
    [HttpDelete("{id}")]
    public IActionResult DeletaEndereco(int id)
    {
        var endereco = _context.Enderecos.FirstOrDefault(Endereco => Endereco.IdEndereco == id);
        if (endereco == null)
        {
            return NotFound();
        }
        else
        {
            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }
    }

}
