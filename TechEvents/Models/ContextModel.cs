using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TechEvents.Models
{
    public class TechEventsContext : DbContext
    {
        public TechEventsContext() : base("name=TechEvents")
        { }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
    }
}