using System;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace DataLayer
{
    public class MssqlRepository : IRepository
    {
        Connection conexion = new Connection();
        public DataTable Login(UsuarioT usuario)
        {
            DataTable User = new DataTable();

            try
            {
                string query = "Select CodUsuario, Usuario, Contraseña, TipoUser, Avatar, FkCodigoTemplate FROM UsuarioT where Usuario=@Usuario and Contraseña=@Contraseña";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {
                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                comando.Parameters.AddWithValue("@Contraseña", usuario.Password);

                adaptador.Fill(User);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return User;

        }

        public DataTable VerifyUser(UsuarioT usuario)
        {
            DataTable User = new DataTable();

            try
            {
                string query = "Select Usuario FROM UsuarioT where Usuario=@Usuario;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {
                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@Usuario", usuario.Usuario);

                adaptador.Fill(User);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return User;

        }

        public DataTable VerifySimCard(SimCard sim)
        {
            DataTable User = new DataTable();

            try
            {
                string query = "Select NumSim FROM SimCard where NumSim=@NumSim;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {
                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@NumSim", sim.NumSim);

                adaptador.Fill(User);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return User;

        }

        public DataTable VerifyImei(EquipoGps gps)
        {
            DataTable User = new DataTable();

            try
            {
                string query = "Select Imei FROM EquipoGps where Imei=@Imei;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {
                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@NumSim", gps.Imei);

                adaptador.Fill(User);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return User;

        }

        public DataTable VerifyPlaca(Vehiculos carro)
        {
            DataTable User = new DataTable();

            try
            {
                string query = "Select PlacaVehiculo FROM Vehiculos where PlacaVehiculo=@PlacaVehiculo;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {
                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@PlacaVehiculo", carro.PlacaVehiculo);

                adaptador.Fill(User);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return User;

        }

        public DataTable Buscador(UsuarioT usuario)
        {
            DataTable Buscar = new DataTable();

            try
            {
                string query = " select CodUsuario, NombreUsuario, Apellido, Usuario, Contraseña, TipoUser, NombreCliente, Telefono, Correo from UsuarioT " +
                    "join Cliente on CodCli = FkCodCli where NombreUsuario like  '%' + @NombreUsuario + '%' ";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };



                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);

                adaptador.Fill(Buscar);
            }


            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Buscar;
        }

        public DataTable ConsultarTemplate()
        {

            DataTable Tabla = new DataTable();

            try
            {
                string query = "Select CodigoTemplate, ImagenTemplate, TituloTemplate from EstiloTemplate;";
                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                adaptador.Fill(Tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Tabla;
        }    

        public DataTable ConsultaInfo()
        {
            DataTable Tabla = new DataTable();

            try
            {
                string query = "Select CodUsuario, UsuarioT.NombreUsuario, Apellido, Usuario, Contraseña, TipoUser, Cliente.NombreCliente, Cliente.Telefono, Cliente.Correo FROM UsuarioT," +
                    " Cliente where UsuarioT.FkCodCli = Cliente.CodCli;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                adaptador.Fill(Tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }
          
            finally
            {
                conexion.CerrarConexion();
            }
            return Tabla;
        }

        public DataTable ConsultaSims()
        {
            DataTable Tabla = new DataTable();

            try
            {
                string query = "Select Cliente.NombreCliente, CodSim, NumSim, Operador from SimCard, Cliente where SimCard.FkCodCli = Cliente.CodCli;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                adaptador.Fill(Tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Tabla;
        }

        public DataTable ConsultaEquiposGps()
        {
            DataTable Tabla = new DataTable();

            try
            {
                string query = "Select NombreCliente, Imei, Serial, NumSim from EquipoGps, SimCard, Cliente where EquipoGps.FkCodCli = Cliente.CodCli " +
                    "and EquipoGps.FkCodSim = SimCard.CodSim;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                adaptador.Fill(Tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Tabla;
        }

        public DataTable ConsultaVehiculos()
        {
            DataTable Tabla = new DataTable();

            try
            {
                string query = "Select PlacaVehiculo,MarcaVehiculo,ColorVehiculo,ModeloVehiculo,CilindrajeVehiculo, NombreCliente, Imei, Usuario from " +
                    "Vehiculos,EquipoGps,UsuarioT, Cliente where Vehiculos.FkCod_Cli = Cliente.CodCli and Vehiculos.FkCodigoGps = EquipoGps.CodigoGps and " +
                    "Vehiculos.FkCodUsuario = UsuarioT.CodUsuario; ";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                adaptador.Fill(Tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Tabla;
        }


        public DataTable ConsultaClientes()
        {
            DataTable Tabla = new DataTable();

            try
            {
                string query = "Select NombreCliente, RepreLegal, Direccion, Telefono, CedulaCiu, Nit, Correo from Cliente;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                adaptador.Fill(Tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Tabla;
        }

        public DataTable ConsultaUser(int id)
        {

            DataTable Usuario = new DataTable();

            try
            {
                string query = "select CodUsuario, NombreUsuario, Apellido, Usuario, Contraseña, TipoUser, NombreCliente from UsuarioT join Cliente on " +
                        "Cliente.CodCli = UsuarioT.FkCodCli where CodUsuario like @CodUsuario;";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@CodUsuario", id);

                adaptador.Fill(Usuario);
            }


            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return Usuario;

        }

        public DataTable ConsultarTemplatebyid(byte id)
        {

             DataTable Tabla = new DataTable();

            try
            {
                string query = "Select ImagenTemplate from EstiloTemplate where CodigoTemplate=@CodigoTemplate;";
                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@CodigoTemplate", id);

                adaptador.Fill(Tabla);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Tabla;
        }

        public DataTable ConsultarClientetoEdit(string NombreCliente)
        {

            DataTable Usuario = new DataTable();

            try
            {
                string query = "select NombreCliente,RepreLegal,Direccion, Telefono, CedulaCiu, Nit, Correo from Cliente where NombreCliente like @NombreCliente; ";

                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@NombreCliente", NombreCliente);

                adaptador.Fill(Usuario);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Usuario;

        }

        //"select NombreCliente,RepreLegal,Direccion, Telefono, CedulaCiu, Nit, Correo from Cliente where NombreCliente like '" + NombreCliente + "';"

        public DataTable ConsultarSimEdit(string NumSim)
        {

            DataTable Usuario = new DataTable();

            try
            {
                string query = "select CodSim, NumSim, Operador, NombreCliente from SimCard join Cliente on Cliente.CodCli = SimCard.FkCodCli where " +
                    "NumSim like @NumSim;"; 
        
            
                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@NumSim", NumSim);

                adaptador.Fill(Usuario);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return Usuario;

        }

        public DataTable ConsultarGpsEdit(string Imei)
        {

            DataTable Usuario = new DataTable();

            try
            {
                string query = "select CodigoGps, Imei, Serial, NumSim, NombreCliente " +
                    "from EquipoGps inner join Cliente on Cliente.CodCli = EquipoGps.FkCodCli " +
                    "inner join SimCard on SimCard.CodSim = EquipoGps.FkCodSim where Imei like @Imei;";



                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@Imei", Imei);




                adaptador.Fill(Usuario);
            }


            catch (Exception ex)
            {
                throw ex;
            }




            finally
            {
                conexion.CerrarConexion();
            }
            return Usuario;

        }

        public DataTable ConsultarVehiculosedit(string PlacaVehiculo)
        {

            DataTable Usuario = new DataTable();

            try
            {
                string query = "Select NombreCliente, Imei, Usuario, CodigoVehiculo, PlacaVehiculo, MarcaVehiculo, ColorVehiculo, ModeloVehiculo, CilindrajeVehiculo " +
                    "from Vehiculos inner join Cliente on Cliente.CodCli = Vehiculos.FkCod_Cli inner join EquipoGps on EquipoGps.CodigoGps = Vehiculos.FkCodigoGps inner join " +
                    "UsuarioT on UsuarioT.CodUsuario = Vehiculos.FkCodUsuario where PlacaVehiculo like @PlacaVehiculo;";



                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {

                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@PlacaVehiculo", PlacaVehiculo);           

                adaptador.Fill(Usuario);
            }


            catch (Exception ex)
            {
                throw ex;
            }




            finally
            {
                conexion.CerrarConexion();
            }
            return Usuario;

        }

        public DataTable ConsultarNameCliente()
        {

            DataTable NameCliente = new DataTable();

            try
            {
                string query = "select CodCli, NombreCliente from Cliente; ";


                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                adaptador.Fill(NameCliente);
            }


            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return NameCliente;

        }

        public DataTable ConsultarNameUsuario()
        {

            DataTable NameUsuario = new DataTable();

            try
            {
                string query = "select CodUsuario, Usuario from UsuarioT; ";


                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                adaptador.Fill(NameUsuario);
            }


            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return NameUsuario;

        }

        public DataTable ConsultarNumerosSimCard(int id)
        {

            DataTable NumerosSim = new DataTable();

            try
            {
                string query = "select CodSim, NumSim from SimCard JOIN Cliente ON Cliente.CodCli = SimCard.FkCodCli where CodCli=@CodCli;";


                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@CodCli", id);

                adaptador.Fill(NumerosSim);
            }


            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return NumerosSim;

        }

        public DataTable ConsultarUsuariosdeunCliente(int id)
        {

            DataTable NumerosSim = new DataTable();

            try
            {
                string query = "select CodUsuario, Usuario from UsuarioT join Cliente on Cliente.CodCli = UsuarioT.FkCodCli where CodCli=@CodCli;";


                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@CodCli", id);

                adaptador.Fill(NumerosSim);
            }


            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return NumerosSim;

        }

        public DataTable ConsultarEquiposdeunCliente(int id)
        {

            DataTable NumerosSim = new DataTable();

            try
            {
                string query = "select CodigoGps, Imei from EquipoGps join Cliente on Cliente.CodCli = EquipoGps.FkCodCli where CodCli=@CodCli;";


                SqlCommand comando = new SqlCommand(query, conexion.CrearConexion())
                {
                    CommandType = CommandType.Text
                };


                SqlDataAdapter adaptador = new SqlDataAdapter()
                {



                    SelectCommand = comando
                };

                comando.Parameters.AddWithValue("@CodCli", id);

                adaptador.Fill(NumerosSim);
            }


            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.CerrarConexion();
            }
            return NumerosSim;

        }

        public int CrearUsuario(UsuarioT usuario)
        {
         string query = "INSERT INTO UsuarioT (NombreUsuario, Apellido, Usuario, Contraseña, TipoUser, FkCodCli, Avatar, FkCodigoTemplate) VALUES (@NombreUsuario, @Apellido, @Usuario, @Contraseña, @TipoUser, @CodCli, @Avatar, @FkCodigoTemplate);";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());


            comando.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
            comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            comando.Parameters.AddWithValue("@Usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@Contraseña",usuario.Password );
            comando.Parameters.AddWithValue("@TipoUser", usuario.TipoUser);
            comando.Parameters.AddWithValue("@CodCli", usuario.FkCodCli);

            var avatar = comando.Parameters.AddWithValue("@Avatar", usuario.Avatar);
            if (usuario.Avatar == null)
                avatar.Value = DBNull.Value;

            var template = comando.Parameters.AddWithValue("@FkCodigoTemplate", usuario.CodigoTemplate);
            if (usuario.CodigoTemplate == 0)
                template.Value = DBNull.Value;


            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }    

        public int CrearCliente(Cliente cliente)
        {
 

            string query = @"INSERT INTO Cliente (NombreCliente, RepreLegal, Direccion, Telefono,CedulaCiu, Nit, Correo) VALUES(@NombreCliente, @RepreLegal, @Direccion, @Telefono, @CedulaCiu, @Nit, @Correo)
            ";

        
            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());


            comando.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);

            var reprelegal = comando.Parameters.AddWithValue("@RepreLegal", cliente.RepreLegal);
            if (cliente.RepreLegal == null)
                reprelegal.Value = DBNull.Value;

            comando.Parameters.AddWithValue("@Direccion", cliente.Dirección);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);

            var cedulaCiu = comando.Parameters.AddWithValue("@CedulaCiu", cliente.CedulaCiu);
            if (cliente.CedulaCiu == 0)
                cedulaCiu.Value = DBNull.Value;

            var nit = comando.Parameters.AddWithValue("@Nit", cliente.Nit);
            if (cliente.Nit == null)
                nit.Value = DBNull.Value;

            comando.Parameters.AddWithValue("@Correo", cliente.Correo);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int CrearSimCard(SimCard sim)
        {

            string query = @"INSERT INTO SimCard (Operador, NumSim, FkCodCli) VALUES(@Operador, @NumSim, @FkCodCli)";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());        
          

            comando.Parameters.AddWithValue("@Operador", sim.Operador);
            comando.Parameters.AddWithValue("@NumSim", sim.NumSim);
            comando.Parameters.AddWithValue("@FkCodCli", sim.FkCodCli);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int CrearTemplate(Template plantilla)
        {
            string query = "Insert into EstiloTemplate (ImagenTemplate,TituloTemplate) VALUES (@ImagenTemplate, @TituloTemplate)";

            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            var template = comando.Parameters.AddWithValue("@ImagenTemplate", plantilla.ImagenTemplate);
            if (plantilla.ImagenTemplate == null)
                template.Value = DBNull.Value;

            comando.Parameters.AddWithValue("@TituloTemplate", plantilla.TituloTemplate);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int CrearEquipoGps(EquipoGps Gps)
        {

            string query = @"INSERT INTO EquipoGps (Imei, Serial, FkCodSim, FkCodCli) VALUES (@Imei, @Serial, @FkCodSim, @FkCodCli)";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@FkCodCli", Gps.FkCodCli);
            comando.Parameters.AddWithValue("@FkCodSim", Gps.FkCodSim);
            comando.Parameters.AddWithValue("@Imei", Gps.Imei);
            comando.Parameters.AddWithValue("@Serial", Gps.Serial);
                     
            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int CrearVehiculos(Vehiculos carro)
        {

            string query = @"Vehiculos(PlacaVehiculo,MarcaVehiculo,ColorVehiculo,ModeloVehiculo,CilindrajeVehiculo,FkCodigoGps,FkCod_Cli,FkCodUsuario)
                VALUES (@PlacaVehiculo, @MarcaVehiculo, @ColorVehiculo, @ModeloVehiculo, @CilindrajeVehiculo, @FkCodigoGps, @FkCod_Cli, @FkCodUsuario)";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@PlacaVehiculo", carro.PlacaVehiculo);
            comando.Parameters.AddWithValue("@MarcaVehiculo", carro.MarcaVehiculo);
            comando.Parameters.AddWithValue("@ColorVehiculo", carro.ColorVehiculo);
            comando.Parameters.AddWithValue("@ModeloVehiculo", carro.ModeloVehiculo);
            comando.Parameters.AddWithValue("@CilindrajeVehiculo", carro.CilindrajeVehiculo);
            comando.Parameters.AddWithValue("@FkCodigoGps", carro.FkCodigoGps);
            comando.Parameters.AddWithValue("@FkCod_Cli", carro.FkCodCli);
            comando.Parameters.AddWithValue("@FkCodUsuario", carro.FkCodUsuario);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }


        public bool EditarUsuario(UsuarioT usuario)
        {

            bool ejecutar;

            string query = "UPDATE UsuarioT Set NombreUsuario=@NombreUsuario, Apellido=@Apellido, Contraseña=@Contraseña, TipoUser=@TipoUser, Avatar=@Avatar," +
                "FkCodigoTemplate=@FkCodigoTemplate WHERE CodUsuario=@CodUsuario;";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());


            comando.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
            comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            comando.Parameters.AddWithValue("@Contraseña", usuario.Password);
            comando.Parameters.AddWithValue("@TipoUser", usuario.TipoUser);
            comando.Parameters.AddWithValue("@CodUsuario", usuario.CodUsuario);

            var avatar = comando.Parameters.AddWithValue("@Avatar", usuario.Avatar);
            if (usuario.Avatar == null)
                avatar.Value = DBNull.Value;

            var template = comando.Parameters.AddWithValue("@FkCodigoTemplate", usuario.CodigoTemplate);
            if (usuario.CodigoTemplate == 0)
                template.Value = DBNull.Value;



            int filas = comando.ExecuteNonQuery();

            if (filas > 0)
            {
                ejecutar = true;
            }
            else
            {
                ejecutar = false;
            }

            conexion.CerrarConexion();

            return ejecutar;

        }               

        public bool EditarCliente(Cliente cliente)
        {
            bool ejecutar; 

            string query = "UPDATE Cliente Set NombreCliente=@NombreCliente, RepreLegal=@RepreLegal, Direccion=@Direccion, Telefono=@Telefono, CedulaCiu=@CedulaCiu," +
                " Nit=@Nit, Correo=@Correo WHERE CodCli=@CodCli";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodCli", cliente.CodCli);
            comando.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);

            var reprelegal = comando.Parameters.AddWithValue("@RepreLegal", cliente.RepreLegal);
            if (cliente.RepreLegal == null)
                reprelegal.Value = DBNull.Value;

            comando.Parameters.AddWithValue("@Direccion", cliente.Dirección);
            comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);

            var cedulaCiu = comando.Parameters.AddWithValue("@CedulaCiu", cliente.CedulaCiu);
            if (cliente.CedulaCiu == 0)
                cedulaCiu.Value = DBNull.Value;

            var nit = comando.Parameters.AddWithValue("@Nit", cliente.Nit);
            if (cliente.Nit == null)
                nit.Value = DBNull.Value;

            comando.Parameters.AddWithValue("@Correo", cliente.Correo);

            int filas = comando.ExecuteNonQuery();

            if (filas > 0)
            {
                ejecutar = true;
            }
            else
            {
                ejecutar = false;
            }

            conexion.CerrarConexion();

            return ejecutar;

        }

        public int EditarSimCard(SimCard sim)
        {


            string query = "UPDATE SimCard Set Operador=@Operador, NumSim=@NumSim WHERE CodSim like @CodSim;";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodSim", sim.CodSim);
            comando.Parameters.AddWithValue("@Operador", sim.Operador);
            comando.Parameters.AddWithValue("@NumSim", sim.NumSim);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int EditEquipoGps(EquipoGps gps)
        {


            string query = "UPDATE EquipoGps Set Imei=@Imei, Serial=@Serial WHERE CodigoGps like @CodigoGps;";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodigoGps", gps.CodigoGps);
            comando.Parameters.AddWithValue("@Imei", gps.Imei);
            comando.Parameters.AddWithValue("@Serial", gps.Serial);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int EditVehiculos(Vehiculos carro)
        {

            string query = "UPDATE Vehiculos Set PlacaVehiculo=@PlacaVehiculo, MarcaVehiculo=@MarcaVehiculo, ColorVehiculo=@ColorVehiculo, ModeloVehiculo=@ModeloVehiculo," +
                " CilindrajeVehiculo=@CilindrajeVehiculo WHERE  CodigoVehiculo like @CodigoVehiculo;";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodigoVehiculo", carro.CodigoVehiculo);
            comando.Parameters.AddWithValue("@PlacaVehiculo", carro.PlacaVehiculo);
            comando.Parameters.AddWithValue("@MarcaVehiculo", carro.MarcaVehiculo);
            comando.Parameters.AddWithValue("@ColorVehiculo", carro.ColorVehiculo);
            comando.Parameters.AddWithValue("@ModeloVehiculo", carro.ModeloVehiculo);
            comando.Parameters.AddWithValue("@CilindrajeVehiculo", carro.CilindrajeVehiculo);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int EliminarUsuario(UsuarioT usuario)
        {

            string query = "DELETE FROM UsuarioT where CodUsuario = @CodUsuario";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodUsuario", usuario.CodUsuario);


            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }
        public int EliminarCliente(Cliente cliente)
        {

            string query = "DELETE FROM Cliente where NombreCliente=@NombreCliente";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);


            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int EliminarSimCard(SimCard sim)
        {

            string query = "DELETE FROM SimCard where CodSim=@CodSim";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodSim", sim.CodSim);


            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int EliminarEquipoGps(EquipoGps gps)
        {

            string query = "DELETE FROM EquipoGps where CodigoGps=@CodigoGps";


            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodigoGps", gps.CodigoGps);


            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

        public int EliminarVehiculos(Vehiculos carro)
        {
            string query = "DELETE FROM Vehiculos where CodigoVehiculo=@CodigoVehiculo";

            SqlCommand comando = new SqlCommand(query, conexion.CrearConexion());

            comando.Parameters.AddWithValue("@CodigoVehiculo", carro.CodigoVehiculo);

            int filas = comando.ExecuteNonQuery();

            conexion.CerrarConexion();

            return filas;

        }

    }


}





