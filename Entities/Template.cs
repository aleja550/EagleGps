using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Template
    {

        public byte CodigoTemplate { get; set; }
        public byte[] ImagenTemplate { get; set; }
        public string TituloTemplate { get; set; }


        public Template() { }

    }
}