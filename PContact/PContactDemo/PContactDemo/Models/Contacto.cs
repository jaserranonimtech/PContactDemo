using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PContactDemo.Models
{
    public class Contacto
    {
        //atributos
        
        public int  IdContacto { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required]
        public string Telefono { get; set; }
        public string Telefeno2 { get; set; }
        [Required]
        public string CorreoElectronico { get; set; }
        public string CorreoElectronico2 { get; set; }
        [Required]
        public bool Activo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion  { get;  set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        [Required]
        public TipoContacto TipodeContacto { get; set; }
        public ContactoDireccion ContactoDirecion { get; set; }


    }
}