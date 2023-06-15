using Microsoft.EntityFrameworkCore;
using OdontoAPI.Models;
using System.Data;

namespace OdontoAPI.Data;

public class OdontoApiContext : DbContext
{
    public OdontoApiContext(DbContextOptions<OdontoApiContext> opts) : base(opts) 
    {

    }   
    public DbSet<FormaPgto> FormaPgtos { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
    public DbSet<TipoSala> TipoSalas { get; set; }
    public DbSet<Sala> Salas { get; set; }
    public DbSet<TipoTratamento> TipoTratamentos { get; set; }
    public DbSet<Tratamento> Tratamentos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Orcamento> Orcamentos { get; set; }
    public DbSet<Dentista> Dentistas { get; set; }
}
