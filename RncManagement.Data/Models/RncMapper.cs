using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHelpers;

namespace RncManagement.Data.Models
{
    /// <summary>
    /// Entidad usada para mapear. El atributo DelimitedRecord sirve para indicarle a la clase de FileHelpers como
    /// parsear el archivo CSV. No se utilizó directamente la clase RNC porque las reglas de mapeo del CSV se deben 
    /// definir como fields y no como propiedades con GET/SET (una debilidad del dll que parsea el archivo)
    /// </summary>
    [DelimitedRecord("|")]
    public class RncMapper
    {
        public string NumeroRnc;
        public string RazonSocial;
        public string NombreComercial;
        public string ActividadPrincipal;
        public string DireccionCalle;
        public string DireccionNumero;
        public string DireccionSector;
        public string Telefono;
        public string FechaConstitucion;        
        public string RegimenPago;
        public string Estado;

    }
}
