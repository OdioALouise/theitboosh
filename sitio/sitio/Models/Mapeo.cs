using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sitio.Models
{
    public class mapeoDBContext: DbContext
    {
        public DbSet<Persona> personas { get; set; }
    }
}