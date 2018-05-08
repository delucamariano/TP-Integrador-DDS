using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CFecha;

namespace CUsuario
{
    public class Usuario
    {
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Password { get; set; }
        public Fecha FechaDeAlta;
       

    }
}