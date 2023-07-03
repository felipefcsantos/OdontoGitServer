using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OdontoAPI.Data;
using OdontoAPI.Data.DTOs;
using OdontoAPI.Models;

namespace OdontoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FormaPgtoController : ControllerBase
{

    private OdontoApiContext _context;
    private IMapper _mapper;

    public FormaPgtoController(OdontoApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaFormaPgto([FromBody] CreateFormaPgtoDto formaPgtoDto)
    {
        FormaPgto formaPgto = _mapper.Map<FormaPgto>(formaPgtoDto);
        _context.FormaPgtos.Add(formaPgto);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscaFormaPgto), new { id = formaPgto.IdFormaDePagamento }, formaPgto);
    }

    [HttpGet]
    public IEnumerable<ReadFormaPgtoDto> ListaFormaPgto([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadFormaPgtoDto>>(_context.FormaPgtos.Skip(skip).Take(take).ToList());
    }
    [HttpGet("{Ativo}")]
    public IEnumerable<ReadFormaPgtoDto> ListaFormaPgtoAtivos(Boolean Ativo, [FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        if (Ativo == true)
        {
            return _mapper.Map<List<ReadFormaPgtoDto>>(_context.FormaPgtos.Where(formaPgto => formaPgto.Ativo == Ativo).Skip(skip).Take(take));
        }
        else
        {
            return _mapper.Map<List<ReadFormaPgtoDto>>(_context.FormaPgtos.Skip(skip).Take(take));
        }
    }
    [HttpGet("{id}")]
    public IActionResult BuscaFormaPgto(int id)
    {

        var formapgto = _context.FormaPgtos.FirstOrDefault(formaPgto => formaPgto.IdFormaDePagamento == id);
        if (formapgto == null)
        {
            return NotFound();
        }
        else
        {
            var formaPgtoDto = _mapper.Map<ReadFormaPgtoDto>(formapgto);
            return Ok(formaPgtoDto);
        }
    }
    [HttpPut("{id}")]
    public IActionResult AtivaDesativaPutFormaPgto(int id, UpdateFormaPgtoDto formaPgtoDto)
    {
        var formapgto = _context.FormaPgtos.FirstOrDefault(formaPgto => formaPgto.IdFormaDePagamento == id);
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
    [HttpPatch("{id}")]
    public IActionResult AtivaDesativaPacthFormaPgto(int id, JsonPatchDocument<UpdateFormaPgtoDto> patch)
    {
        var formapgto = _context.FormaPgtos.FirstOrDefault(formaPgto => formaPgto.IdFormaDePagamento == id);
        if (formapgto == null)
        {
            return NotFound();
        }
        else
        {
            var formaPgtoParaAtualizar = _mapper.Map<UpdateFormaPgtoDto>(formapgto);
            patch.ApplyTo(formaPgtoParaAtualizar, ModelState);

            if (!TryValidateModel(ModelState))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(formaPgtoParaAtualizar, formapgto);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
