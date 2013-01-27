using System;
using System.ComponentModel.DataAnnotations;
using FileHelpers;

namespace RncManagement.Data.Models
{
    /// <summary>
    /// Entidad Principal. Define la tabla que se creará en la BD para guardar los registros
    /// </summary>
    public class RNC
    {
        [Key]
        public string NumeroRnc { get; set; }        
        
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ActividadPrincipal { get; set; }
        public string DireccionCalle { get; set; }
        public string DireccionNumero { get; set; }
        public string DireccionSector { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaConstitucion { get; set; }
        public string RegimenPago { get; set; }
        public string Estado { get; set; }
    }

}
