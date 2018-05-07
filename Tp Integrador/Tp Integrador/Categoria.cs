using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCategoria
{
    public class Categoria
    {
        private double CargoFijoMensual { get; set; }
        private double CargoVariableKwH { get; set; }
        public string Nombre { get; set; }
        public List<double> RangoConsumo;

        public Categoria(double cargoFijo, double cargoVar, string nombre, double rangoMin,double rangoMax)
        {
            CargoFijoMensual = cargoFijo;
            CargoVariableKwH = cargoVar;
            Nombre = nombre;
            RangoConsumo = new List<double>();
            RangoConsumo.Add(rangoMin);
            RangoConsumo.Add(rangoMax);
        }
    }
}