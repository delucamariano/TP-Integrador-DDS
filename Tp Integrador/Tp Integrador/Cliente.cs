using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CCategoria;
using CDispositivo;
using CUsuario;

namespace CCliente
{
    public class Cliente : Usuario
    {
        public Categoria Categoria;
        public List<Dispositivo> Dispositivos { get; set; }
        public int NroDocumento { get; set; }
        public int TelefonoContacto { get; set; }
        public string TipoDeDocumento { get; set; }

       
        public bool AlgunDispositivoEncendido()
        {

            var resultado =  Dispositivos.Exists(x => x.Encendido == true);

            if (resultado == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public int CantDispositivosEncendidos()
        {
            return Dispositivos.FindAll(x => x.Encendido == true).Count;
            
        }
        public int CantDispositivosApagados()
        {
            return CantDispositivos() - CantDispositivosEncendidos();
        }
        public int CantDispositivos()
        {
            return Dispositivos.Count;
        }
    }
}