using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class SimCard
    {

        public int CodSim { get; set; }
        public string Operador { get; set; }
        public long NumSim { get; set; }
        public int FkCodCli { get; set; }

        public SimCard() { }
        public SimCard(int CodSim, string Operador, long NumeroSimCard, int CodCli)
        {
            this.CodSim = CodSim;
            this.Operador = Operador;
            NumSim = NumeroSimCard;
            FkCodCli = CodCli;           
        }
    }
}