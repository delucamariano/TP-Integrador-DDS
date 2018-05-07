using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFecha
{
    public class Fecha
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }

        public Fecha(int d ,int m, int a)
        {
            Dia = d;
            Mes = m;
            Año = a;
        }
       
    }
}