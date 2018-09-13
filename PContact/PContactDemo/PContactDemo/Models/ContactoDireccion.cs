using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PContactDemo.Models
{
    public class ContactoDireccion
    {
      
        public int IdContactoDireccion { get; set; }
        [Required]
        public string Calle { get; set; }

        public string Colonia { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Ciudad { get; set; }
        public string Delegacion { get; set; }

        [Required]
        public string CodigoPostal { get; set; }
        public string Referencia { get; set; }
        public string NoInt { get; set; }
        public string NoExt { get; set; }
        

    }
}