using System.Data;
using DataLayer;
using Entities;

namespace LogicLayer
{
    public class RepositoryLogic
    {
        IRepository _repository;

        public RepositoryLogic(IRepository repository) // Builder
        {
            _repository = repository;
        }

        public DataTable Login(UsuarioT usuario)
        {
            return _repository.Login(usuario);
        }

        public DataTable VerifySimCard(SimCard sim)
        {
            return _repository.VerifySimCard(sim);
        }
        public DataTable VerifyUser(UsuarioT usuario)
        {
            return _repository.VerifyUser(usuario);
        }
        public DataTable VerifyImei(EquipoGps gps)
        {
            return _repository.VerifyImei(gps);
        }
        public DataTable VerifyPlaca(Vehiculos carro)
        {
            return _repository.VerifyPlaca(carro);
        }
        public DataTable Buscador(UsuarioT usuario)
        {
            return _repository.Buscador(usuario);
        }

        public DataTable ConsultarTemplate()
        {
            return _repository.ConsultarTemplate();
        }
        public DataTable ConsultaInfo()
        {
            return _repository.ConsultaInfo();
        }

        public DataTable ConsultaSims()
        {
            return _repository.ConsultaSims();
        }
        public DataTable ConsultaEquiposGps()
        {
            return _repository.ConsultaEquiposGps();
        }

        public DataTable ConsultaVehiculos()
        {
            return _repository.ConsultaVehiculos();
        }

        public DataTable ConsultaUser(int id)
        {
            return _repository.ConsultaUser(id);
        }
        public DataTable ConsultarTemplatebyid(byte id)
        {
            return _repository.ConsultarTemplatebyid(id);
        }
        public DataTable ConsultarClientetoEdit(string NombreCliente)
        {
            return _repository.ConsultarClientetoEdit(NombreCliente);
        }
        public DataTable ConsultarSimEdit(string NumSim)
        {
            return _repository.ConsultarSimEdit(NumSim);
        }

        public DataTable ConsultarGpsEdit(string Imei)
        {
            return _repository.ConsultarGpsEdit(Imei);
        }

        public DataTable ConsultarVehiculosedit(string PlacaVehiculo)
        {
            return _repository.ConsultarVehiculosedit(PlacaVehiculo);
        }

        public DataTable ConsultarNameCliente()
        {
            return _repository.ConsultarNameCliente();
        }

        public DataTable ConsultarNumerosSimCard(int id)
        {
            return _repository.ConsultarNumerosSimCard(id);
        }

        public DataTable ConsultaClientes()
        {
            return _repository.ConsultaClientes();
        }

        public DataTable ConsultarNameUsuario()
        {
            return _repository.ConsultarNameUsuario();
        }

        public DataTable ConsultarUsuariosdeunCliente(int id)
        {
            return _repository.ConsultarUsuariosdeunCliente(id);
        }
        public DataTable ConsultarEquiposdeunCliente(int id)
        {
            return _repository.ConsultarEquiposdeunCliente(id);
        }

        public int CrearTemplate(Template plantilla)
        {
            return _repository.CrearTemplate(plantilla);
        }
        public int CrearUsuario(UsuarioT usuario)
        {
            return _repository.CrearUsuario(usuario);
        }
        public int CrearCliente(Cliente cliente)
        {
            return _repository.CrearCliente(cliente);
        }
        public int CrearSimCard(SimCard sim)
        {
            return _repository.CrearSimCard(sim);
        }

        public int CrearEquipoGps(EquipoGps Gps)
        {
            return _repository.CrearEquipoGps(Gps);
        }
        public int CrearVehiculos(Vehiculos carro)
        {
            return _repository.CrearVehiculos(carro);
        }

        public bool EditarUsuario(UsuarioT usuario)
        {
            return _repository.EditarUsuario(usuario);
        }            

        public int EditarSimCard(SimCard sim)
        {
            return _repository.EditarSimCard(sim);
        }

        public int EditEquipoGps(EquipoGps gps)
        {
            return _repository.EditEquipoGps(gps);
        }
        public int EditVehiculos(Vehiculos carro)
        {
            return _repository.EditVehiculos(carro);
        }

        public bool EditarCliente(Cliente cliente)
        {
            return _repository.EditarCliente(cliente);
        }

        public int EliminarCliente(Cliente cliente)
        {
            return _repository.EliminarCliente(cliente);
        }

        public int EliminarUsuario(UsuarioT usuario)
        {
            return _repository.EliminarUsuario(usuario);
        }
        public int EliminarSimCard(SimCard sim)
        {
            return _repository.EliminarSimCard(sim);
        }
        public int EliminarEquipoGps(EquipoGps gps)
        {
            return _repository.EliminarEquipoGps(gps);
        }

        public int EliminarVehiculos(Vehiculos carro)
        {
            return _repository.EliminarVehiculos(carro);
        }

    }

}