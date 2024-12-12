using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechEvents.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public string UsuarioRegistro { get; set; }

        public string EstadoDisplay { get { return Estado ? "Activo" : "No Activo"; } }
    }

}