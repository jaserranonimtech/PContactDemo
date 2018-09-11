using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PContactDemo.Models
{
    public class Auditoria
    {
        public bool Activo { get; set; }
        [MaxLength(150)]
        [Display(Name ="Usuario Creacion")]
        public string UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime FechaCreacion { get; set; }
        [MaxLength(150)]
        [Display(Name = "Usuario Modificacion")]
        public string UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime FechaModificacion { get; set; }
    }
}