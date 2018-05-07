using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CCategoria;

namespace CCategorias
{
    public class Categorias
    {
        public static Categoria R1 = new Categoria(18.76,0.644,"R1",0.0,150.0);
        public static Categoria R2 = new Categoria(35.32, 0.644,"R2", 150.0, 325.0);
        public static Categoria R3 = new Categoria(60.71, 0.681,"R3" ,325.0, 400.0);
        public static Categoria R4 = new Categoria(71.74, 0.738, "R4",400.0, 450.0);
        public static Categoria R5 = new Categoria(110.38, 0.794,"R5" ,450.0, 500.0);
        public static Categoria R6 = new Categoria(220.75, 0.832, "R6",500.0, 600.0);
        public static Categoria R7 = new Categoria(443.59, 0.851,"R7" ,600, 700);
        public static Categoria R8 = new Categoria(545.96, 0.851, "R8",700, 1400);
        public static Categoria R9 = new Categoria(887.19, 0.851, "R9",1400, 2000);


    }
}