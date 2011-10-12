using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace sitio.Models
{
    public class mapeoDBContext: DbContext
    {
        public DbSet<Persona> personas { get; set; }
        public DbSet<Historia> historias { get; set; }
        public DbSet<Acontecimiento> acontecimientos { get; set; }

        

    }


}