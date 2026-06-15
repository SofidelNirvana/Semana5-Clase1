namespace Semana5_Clase1.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int RolId { get; set; }

        // Propiedad de navegación
        public RolModel? Rol { get; set; }
    }
}
