using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PContactDemo.Models
{
   
    public class TipoContacto : Auditoria
    {
        //Atributos
        [Key]
        public int IdMedioContacto { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Nombre es requerido.")]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [NotMapped]
        public string UsuarioFechaCreacion
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(UsuarioCreacion))
                    return $"Creado por {UsuarioCreacion} {FechaCreacion}";
                else
                    return null;
            }
        }

        [NotMapped]
        public string UsuarioFechaModificacion
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(UsuarioModificacion))
                    return $"Modificado por {UsuarioModificacion} {FechaModificacion}";
                else
                    return null;
            }
        }

    }
}