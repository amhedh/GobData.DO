using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace RncManagement.Data
{
    public class Common
    {
        /// <summary>
        /// Método interno usado para leer las variables de configuración
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string ObtenerValorConfig(string key)
        {
            var reader = new AppSettingsReader();
            return reader.GetValue(key, typeof(string)) as String;
        }

        public static string RutaArchivoCsv
        {
            get { return ObtenerValorConfig("RutaArchivoCsv"); }
        }
    }
}
