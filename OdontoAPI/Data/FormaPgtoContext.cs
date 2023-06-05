using Microsoft.EntityFrameworkCore;
using OdontoAPI.Models;
using System.Data;

namespace OdontoAPI.Data;

public class FormaPgtoContext : DbContext
{
    public FormaPgtoContext(DbContextOptions<FormaPgtoContext> opts) : base(opts) 
    {

    }   
    public DbSet<FormaPgto> FormasPgtos { get; set; }
}
