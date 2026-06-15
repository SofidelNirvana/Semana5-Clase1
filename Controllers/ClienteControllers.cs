using Semana5_Clase1.Data;
using Semana5_Clase1.Models;
using Microsoft.EntityFrameworkCore;

namespace Semana5_Clase1.Controllers
{
    public class ClienteControllers
    {
        private readonly ClientesDbContext _clientesDbContext;
        public ClienteControllers()
        {
            _clientesDbContext = new ClientesDbContext();
        }

        public List<ClienteModel> todos()
        {
            return _clientesDbContext.Clientes.OrderBy(cliente => cliente.Nombre).ToList();
        }
        public ClienteModel uno(int id)
        {
            return _clientesDbContext.Clientes.FirstOrDefault(cl => cl.id == id);
        }
        public string nuevo(ClienteModel cliente)
        {
            try
            {
                _clientesDbContext.Clientes.Add(cliente);
                _clientesDbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string actualizar(ClienteModel cliente)
        {
            try
            {
                var cl = _clientesDbContext.Clientes.Find(cliente.id);
                if (cl == null) throw new Exception("Cliente no encontrado");

                cl.Nombre = cliente.Nombre;
                cl.Cedula = cliente.Cedula;
                cl.Direccion = cliente.Direccion;
                cl.Telefono = cliente.Telefono;
                cl.Correo = cliente.Correo;
                _clientesDbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string eliminar(int id)
        {
            try
            {
                var cl = _clientesDbContext.Clientes.Find(id);
                if (cl == null) throw new Exception("Cliente no encontrado");

                _clientesDbContext.Remove(cl);
                _clientesDbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
// nuevo
