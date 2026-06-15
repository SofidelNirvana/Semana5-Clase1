
using Microsoft.EntityFrameworkCore;
using Semana5_Clase1.Models;

namespace Semana5_Clase1.Data
{
    
    public class ClientesDbContext : DbContext
    {
        public DbSet<ClienteModel> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opb)
        {
            opb.UseSqlServer("server=.;database=Clientes;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
