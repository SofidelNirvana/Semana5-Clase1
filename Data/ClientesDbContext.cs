
using Microsoft.EntityFrameworkCore;
using Semana5_Clase1.Models;

namespace Semana5_Clase1.Data
{
    
    public class ClientesDbContext : DbContext
    {
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<RolModel> Roles { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opb)
        {
            opb.UseSqlServer("server=.;database=Clientes;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>()
                .HasOne(u => u.Rol)
                .WithMany()
                .HasForeignKey(u => u.RolId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
