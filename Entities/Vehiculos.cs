using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Vehiculos
    {
        public int CodigoVehiculo { get; set; }
        public string PlacaVehiculo { get; set; }
        public string MarcaVehiculo { get; set; }
        public string ColorVehiculo { get; set; }
        public string ModeloVehiculo { get; set; }
        public int CilindrajeVehiculo { get; set; }
        public int FkCodigoGps { get; set; }
        public int FkCodCli { get; set; }
        public int FkCodUsuario { get; set; }
        public Vehiculos() { }
        public Vehiculos(int CodigoVehiculo, string Placa, string Marca, string Color, string Modelo, int Cilindraje, int CodigoGps, int CodCli, int CodUsuario)
        {
            this.CodigoVehiculo = CodigoVehiculo;
            PlacaVehiculo = Placa;
            MarcaVehiculo = Marca;
            ColorVehiculo = Color;
            ModeloVehiculo = Modelo;
            CilindrajeVehiculo = Cilindraje;
            FkCodigoGps = CodigoGps;
            FkCodCli = CodCli;
            FkCodUsuario = CodUsuario;
        }
    }
}