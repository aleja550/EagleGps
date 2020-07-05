using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class EquipoGps
    {
        public int CodigoGps { get; set; }
        public long Imei { get; set; }
        public string Serial { get; set; }
        public int FkCodSim { get; set; }
        public int FkCodCli { get; set; }


        public EquipoGps() { }
        public EquipoGps(int CodigoGps, long Imei, string Serial, int CodigoSim, int CodigoCliente)
        {
            this.CodigoGps = CodigoGps;
            this.Imei = Imei;
            this.Serial = Serial;
            FkCodCli = CodigoCliente;
            FkCodSim = CodigoSim;
        }
    }
}