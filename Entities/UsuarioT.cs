
using System;

namespace Entities
{
    public class UsuarioT
    {
        public int CodUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public byte TipoUser { get; set; }
        public int FkCodCli { get; set; }

        public byte[] Avatar { get; set; }

        public byte CodigoTemplate { get; set; }

        public UsuarioT() { }
        public UsuarioT(int CodUsuario, string Nombre, string Apellido, string Usuario, string Password, byte TipoUser,int CodCli)
        {
            this.CodUsuario = CodUsuario;
            this.NombreUsuario = Nombre;
            this.Apellido = Apellido;
            this.Usuario = Usuario;
            this.Password = Password;
            this.TipoUser = TipoUser;
            this.FkCodCli = CodCli;      
        }
    }
}