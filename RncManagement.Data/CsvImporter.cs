using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace RncManagement.Data
{
    /// <summary>
    /// Clase que facilita la lectura y carga del CSV en la base de datos. 
    /// En el futuro sería bueno sacar esto a un servicio y bajar el CSV diariamente para actualizar la base de datos.
    /// Las rutas del archivo están definidas en el app.config y en el web.config.
    /// </summary>
    public class CsvImporter
    {
        /// <summary>
        /// Constructor predeterminado
        /// </summary>
        public CsvImporter()
        {
        }

        /// <summary>
        /// Metodo para leer el archivo y persistirlo en la BD
        /// <remarks>
        /// Este método debería guardar un diferencial diariamente. 
        /// Ahora mismo solo vacia el contenido completo.
        /// </remarks>
        /// </summary>
        public void ImportarArchivo()
        {
            var parseEngine = new FileHelpers.FileHelperEngine<Models.RncMapper>();
            var rncs = parseEngine.ReadFile(Common.RutaArchivoCsv);

            //TODO: Aqui deberiamos usar un método ASYNC para ir enviando mensajes de progreso
            var dbRncList = new List<Models.RNC>();
            for (int i = 0; i < rncs.Length ; i++)
            {
                var item = rncs[i];
                DateTime fecha;
                var dbItem = new Models.RNC
                                 {
                                     NumeroRnc = item.NumeroRnc,
                                     RazonSocial = item.RazonSocial,
                                     NombreComercial = item.NombreComercial,
                                     ActividadPrincipal = item.ActividadPrincipal,
                                     DireccionCalle = item.DireccionCalle,
                                     DireccionNumero = item.DireccionNumero,
                                     DireccionSector = item.DireccionSector,
                                     Telefono = item.Telefono,
                                     RegimenPago = item.RegimenPago,
                                     Estado = item.Estado
                                 };
                if (DateTime.TryParseExact(item.FechaConstitucion, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                {
                    dbItem.FechaConstitucion = fecha;
                }

                dbRncList.Add(dbItem);
            }

            //TODO: Ahora mismo está todo en un método, hay que separar las tareas de parsing de las de escritura en la BD
            var context = new Database();

            //Prueba con los primeros cinco mil registros
            foreach (var rnc in dbRncList.Take(5000))
            {
                context.ListadoRNCs.Add(rnc);
            }
            context.SaveChanges();
        }
    }
}
