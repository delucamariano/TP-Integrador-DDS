using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CUsuario;

namespace CAdministrador
{
    public class Administrador : Usuario
    {
        public int Identificacion { get; set; }

        public int MesesComoAdministrador()
        {
            DateTime fechaActual = DateTime.Now;
            int tiempo = FechaDeAlta.Mes - fechaActual.Month;
            return tiempo;
        }
    }
}