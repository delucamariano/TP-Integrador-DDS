using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CFecha;

namespace CUsuario
{
    public class Usuario
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Domicilio { get; set; }
        private string NombreDeUsuario { get; set; }
        private string Password { get; set; }

        public Fecha FechaDeAlta;
    }
}