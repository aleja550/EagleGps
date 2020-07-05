using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Cliente
    {
        public int CodCli { get; set; }
        public string NombreCliente { get; set; }
        public string RepreLegal { get; set; }
        public string Dirección { get; set; }
        public long Telefono { get; set; }
        public long CedulaCiu { get; set; }
        public string Nit { get; set; }
        public string Correo { get; set; }

        public Cliente() { }
        public Cliente(int CodCli, string Nombre, string RepreLegal, string Direccion, long Telefono, long CedulaCiu, string Nit, string Correo)
        {
            this.CodCli = CodCli;
            this.NombreCliente = Nombre;
            this.RepreLegal = RepreLegal;
            Dirección = Dirección;
            this.Telefono = Telefono;
            this.CedulaCiu = CedulaCiu;
            this.Nit = Nit;
            this.Correo = Correo;
        }
    }
}