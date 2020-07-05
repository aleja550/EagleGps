using DataLayer;
using System.Data;
using Entities;

namespace LogicLayer
{
    public class SqlLogicDb
    {
        RepositoryLogic Bd = new RepositoryLogic(new MssqlRepository());

        DataTable Tabla = new DataTable();

        public DataTable VerifyLogin(UsuarioT usuario)
        {
            try
            {
                Tabla = Bd.Login(usuario);

                if (Tabla.Rows.Count > 0)
                    return Tabla;
            }
            catch
            {
            }
            return null;
        }

        public DataTable VerifyUser(UsuarioT usuario)
        {
            try
            {
                Tabla = Bd.VerifyUser(usuario);

                if (Tabla.Rows.Count > 0)
                    return Tabla;
            }
            catch
            {
            }
            return null;
        }

        public DataTable VerifySimCard(SimCard sim)
        {
            try
            {
                Tabla = Bd.VerifySimCard(sim);

                if (Tabla.Rows.Count > 0)
                    return Tabla;
            }
            catch
            {
            }
            return null;
        }
        public DataTable VerifyImei(EquipoGps gps)
        {
            try
            {
                Tabla = Bd.VerifyImei(gps);

                if (Tabla.Rows.Count > 0)
                    return Tabla;
            }
            catch
            {
            }
            return null;
        }

        public DataTable VerifyPlaca(Vehiculos carro)
        {
            try
            {
                Tabla = Bd.VerifyPlaca(carro);
                if (Tabla.Rows.Count > 0)
                    return Tabla;
            }
            catch
            {
            }
            return null;
        }

        public DataTable Buscador(UsuarioT usuario)
        {
            return Tabla = Bd.Buscador(usuario);
        }

        public DataTable ConsultaInfo()
        {
            return Bd.ConsultaInfo();
        }

        public DataTable ConsultaSims()
        {
            return Bd.ConsultaSims();
        }

        public DataTable ConsultaEquiposGps()
        {
            return Bd.ConsultaEquiposGps();
        }

        public DataTable ConsultaVehiculos()
        {
            return Bd.ConsultaVehiculos();
        }

        public DataTable ConsultarCliente()
        {
            return Bd.ConsultaClientes();
        }

        public DataTable ConsultarTemplate()
        {
            return Bd.ConsultarTemplate();
        }
        public DataTable ConsultarNameUsuario()
        {
            return Bd.ConsultarNameUsuario();
        }

        public DataTable ConsultaUser(int id)
        {
            return Bd.ConsultaUser(id);
        }

        public DataTable ConsultarTemplatebyid(byte id)
        {
            return Bd.ConsultarTemplatebyid(id);
        }

        public DataTable ConsultarClientetoEdit(string NombreCliente)
        {
            return Bd.ConsultarClientetoEdit(NombreCliente);
        }
        public DataTable ConsultarSimEdit(string NumSim)
        {
            return Bd.ConsultarSimEdit(NumSim);
        }
        public DataTable ConsultarGpsEdit(string Imei)
        {
            return Bd.ConsultarGpsEdit(Imei);
        }
        public DataTable ConsultarVehiculosedit(string PlacaVehiculo)
        {
            return Bd.ConsultarVehiculosedit(PlacaVehiculo);
        }
        public DataTable ConsultarNameCliente()
        {
            return Bd.ConsultarNameCliente();
        }

        public DataTable ConsultarNumerosSimCard(int id)
        {
            return Bd.ConsultarNumerosSimCard(id);
        }
        public DataTable ConsultarUsuariosdeunCliente(int id)
        {
            return Bd.ConsultarUsuariosdeunCliente(id);
        }
        public DataTable ConsultarEquiposdeunCliente(int id)
        {
            return Bd.ConsultarEquiposdeunCliente(id);
        }

        public int CrearTemplate(Template plantilla)
        {
            return Bd.CrearTemplate(plantilla);
        }
        public int CrearUsuario(UsuarioT usuario)
        {
            return Bd.CrearUsuario(usuario);
        }
        public int CrearCliente(Cliente cliente)
        {
            return Bd.CrearCliente(cliente);
        }
        public int CrearSimCard(SimCard sim)
        {
            return Bd.CrearSimCard(sim);
        }

        public int CrearEquipoGps(EquipoGps Gps)
        {
            return Bd.CrearEquipoGps(Gps);
        }
        public int CrearVehiculos(Vehiculos carro)
        {
            return Bd.CrearVehiculos(carro);
        }

        public bool EditarUsuario(UsuarioT usuario)
        {
            return Bd.EditarUsuario(usuario);
        }
        public bool EditarCliente(Cliente cliente)
        {
            return Bd.EditarCliente(cliente);
        }
        public int EditEquipoGps(EquipoGps gps)
        {
            return Bd.EditEquipoGps(gps);
        }
        public int EditVehiculos(Vehiculos carro)
        {
            return Bd.EditVehiculos(carro);
        }
        public int EditarSimCard(SimCard sim)
        {
            return Bd.EditarSimCard(sim);
        }
        public int EliminarUsuario(UsuarioT usuario)
        {
            return Bd.EliminarUsuario(usuario);
        }

        public int EliminarCliente(Cliente cliente)
        {
            return Bd.EliminarCliente(cliente);
        }
        public int EliminarSimCard(SimCard sim)
        {
            return Bd.EliminarSimCard(sim);
        }

        public int EliminarEquipoGps(EquipoGps gps)
        {
            return Bd.EliminarEquipoGps(gps);
        }

        public int EliminarVehiculos(Vehiculos carro)
        {
            return Bd.EliminarVehiculos(carro);
        }
    }
}