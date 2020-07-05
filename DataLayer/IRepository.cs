using System.Data;
using Entities;

namespace DataLayer
{
    public interface IRepository
    {
        DataTable Login(UsuarioT usuario);
        DataTable VerifyUser(UsuarioT usuario);
        DataTable VerifySimCard(SimCard sim);
        DataTable VerifyImei(EquipoGps gps);
        DataTable VerifyPlaca(Vehiculos carro);
        DataTable Buscador(UsuarioT usuario);
        DataTable ConsultarTemplate();
        DataTable ConsultaInfo();
        DataTable ConsultaSims();
        DataTable ConsultaEquiposGps();
        DataTable ConsultaVehiculos();
        DataTable ConsultaUser(int id);
        DataTable ConsultarTemplatebyid(byte id);
        DataTable ConsultarClientetoEdit(string NombreCliente);
        DataTable ConsultarSimEdit(string NumSim);
        DataTable ConsultarGpsEdit(string Imei);
        DataTable ConsultarVehiculosedit(string PlacaVehiculo);
        DataTable ConsultarNameCliente();
        DataTable ConsultaClientes();
        DataTable ConsultarNameUsuario();
        DataTable ConsultarNumerosSimCard(int id);
        DataTable ConsultarUsuariosdeunCliente(int id);
        DataTable ConsultarEquiposdeunCliente(int id);

        int CrearTemplate(Template plantilla);
        int CrearUsuario(UsuarioT usuario);       
        int CrearCliente(Cliente cliente);
        int CrearSimCard(SimCard sim);
        int CrearEquipoGps(EquipoGps Gps);
        int CrearVehiculos(Vehiculos carro);
        bool EditarUsuario(UsuarioT usuario);             
        bool EditarCliente(Cliente cliente);
        int EditarSimCard(SimCard sim);
        int EditEquipoGps(EquipoGps gps);
        int EditVehiculos(Vehiculos carro);
        int EliminarCliente(Cliente cliente);
        int EliminarUsuario(UsuarioT usuario);
        int EliminarSimCard(SimCard sim);
        int EliminarEquipoGps(EquipoGps gps);
        int EliminarVehiculos(Vehiculos carro);

    }
}



