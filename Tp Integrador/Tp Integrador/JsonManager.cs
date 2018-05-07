using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CJsonManager
{
    public class JsonManager
    {
        public static string JsonString { get; set; }

      
        public static void LoadJson(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                JsonString = r.ReadToEnd();
              
            }
            return;
        }
    }
}