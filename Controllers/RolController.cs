using Semana5_Clase1.Data;
using Semana5_Clase1.Models;
using Microsoft.EntityFrameworkCore;

namespace Semana5_Clase1.Controllers
{
    public class RolController
    {
        private readonly ClientesDbContext _context;

        public RolController()
        {
            _context = new ClientesDbContext();
        }

        public List<RolModel> Todos()
        {
            return _context.Roles.OrderBy(r => r.NombreRol).ToList();
        }

        public RolModel? Uno(int id)
        {
            return _context.Roles.FirstOrDefault(r => r.id == id);
        }

        public string Nuevo(RolModel rol)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rol.NombreRol))
                    return "El nombre del rol es obligatorio";

                if (_context.Roles.Any(r => r.NombreRol.ToLower() == rol.NombreRol.ToLower()))
                    return "Ya existe un rol con ese nombre";

                _context.Roles.Add(rol);
                _context.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string Actualizar(RolModel rol)
        {
            try
            {
                var rolExistente = _context.Roles.Find(rol.id);
                if (rolExistente == null)
                    return "Rol no encontrado";

                if (string.IsNullOrWhiteSpace(rol.NombreRol))
                    return "El nombre del rol es obligatorio";

                if (_context.Roles.Any(r => r.NombreRol.ToLower() == rol.NombreRol.ToLower() && r.id != rol.id))
                    return "Ya existe un rol con ese nombre";

                rolExistente.NombreRol = rol.NombreRol;
                rolExistente.Descripcion = rol.Descripcion;

                _context.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                var rol = _context.Roles.Find(id);
                if (rol == null)
                    return "Rol no encontrado";

                if (_context.Usuarios.Any(u => u.RolId == id))
                    return "No se puede eliminar: Hay usuarios asignados a este rol";

                _context.Roles.Remove(rol);
                _context.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
