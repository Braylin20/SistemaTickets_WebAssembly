using Microsoft.EntityFrameworkCore;
using SistemaTicketsAssembly.Models;

namespace SistemaTicketsAssembly.DAL
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :base(options) { }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketsDetalle> TicketsDetalle { get; set; }
    }
}
