using Semana5_Clase1.Data;
using Semana5_Clase1.Models;
using Microsoft.EntityFrameworkCore;

namespace Semana5_Clase1.Controllers
{
    public class UsuarioController
    {
        private readonly ClientesDbContext _context;

        public UsuarioController()
        {
            _context = new ClientesDbContext();
        }

        public List<UsuarioModel> Todos()
        {
            return _context.Usuarios
                .Include(u => u.Rol)
                .OrderBy(u => u.NombreCompleto)
                .ToList();
        }

        public UsuarioModel? Uno(int id)
        {
            return _context.Usuarios
                .Include(u => u.Rol)
                .FirstOrDefault(u => u.id == id);
        }

        public string Nuevo(UsuarioModel usuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usuario.Username))
                    return "El nombre de usuario es obligatorio";

                if (string.IsNullOrWhiteSpace(usuario.Password))
                    return "La contraseña es obligatoria";

                if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
                    return "El nombre completo es obligatorio";

                if (_context.Usuarios.Any(u => u.Username.ToLower() == usuario.Username.ToLower()))
                    return "El nombre de usuario ya está en uso";

                if (!string.IsNullOrWhiteSpace(usuario.Email))
                {
                    if (_context.Usuarios.Any(u => u.Email.ToLower() == usuario.Email.ToLower()))
                        return "El correo electrónico ya está registrado";
                }

                var rol = _context.Roles.Find(usuario.RolId);
                if (rol == null)
                    return "El rol seleccionado no existe";

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public string Actualizar(UsuarioModel usuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.Find(usuario.id);
                if (usuarioExistente == null)
                    return "Usuario no encontrado";

                if (string.IsNullOrWhiteSpace(usuario.Username))
                    return "El nombre de usuario es obligatorio";

                if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
                    return "El nombre completo es obligatorio";

                if (_context.Usuarios.Any(u => u.Username.ToLower() == usuario.Username.ToLower() && u.id != usuario.id))
                    return "El nombre de usuario ya está en uso";

                usuarioExistente.Username = usuario.Username;

                if (!string.IsNullOrWhiteSpace(usuario.Password))
                    usuarioExistente.Password = usuario.Password;

                usuarioExistente.NombreCompleto = usuario.NombreCompleto;
                usuarioExistente.Email = usuario.Email;
                usuarioExistente.RolId = usuario.RolId;

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
                var usuario = _context.Usuarios.Find(id);
                if (usuario == null)
                    return "Usuario no encontrado";

                _context.Usuarios.Remove(usuario);
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
