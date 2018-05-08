using System.Collections.Generic;
using CCliente;
using Newtonsoft.Json;
using CJsonManager;
using CAdministrador;
using CDispositivo;
using System.IO;
using System;

namespace CDataManager
{
    public class DataManager
    {
        public static List<Cliente> Clientes;
        public static List<Administrador> Administradores;
        public static List<Dispositivo> Dispositivos;



        private static string ClientesArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"JSON Files/clientes.json");
        private static string AdministradoresArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"JSON Files/administradores.json");
        private static string DispositivosArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"JSON Files/dispositivos.json");

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
