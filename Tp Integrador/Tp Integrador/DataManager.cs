using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CCliente;
using Newtonsoft.Json;
using CJsonManager;
using CAdministrador;
using CDispositivo;

namespace CDataManager
{
    public class DataManager
    {
        public static List<Cliente> Clientes;
        public static List<Administrador> Administradores;
        public static List<Dispositivo> Dispositivos;

        private const string ClientesArchivo = "Tp Integrador/Tp Integrador/clientes.json";
        private const string AdministradoresArchivo = "Tp Integrador/Tp Integrador/administradores.json";
        private const string DispositivosArchivo = "Tp Integrador/Tp Integrador/dispositivos.json";

        public static void LevantarDatos()
        {
            //Cargar Clientes
            
            JsonManager.LoadJson(ClientesArchivo);
            Clientes = JsonConvert.DeserializeObject<List<Cliente>>(JsonManager.JsonString);

            //Cargar Administradores
            JsonManager.LoadJson(AdministradoresArchivo);
            Administradores = JsonConvert.DeserializeObject<List<Administrador>>(JsonManager.JsonString);

            //Cargar Dispositivos

            JsonManager.LoadJson(DispositivosArchivo);
            Dispositivos = JsonConvert.DeserializeObject<List<Dispositivo>>(JsonManager.JsonString);

        }


    }
}
