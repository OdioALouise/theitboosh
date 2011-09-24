using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class Rol
    {
        public int id;
        public string nombre;
        public virtual ICollection<Persona> personas { get; set; }
        
        public Rol(int nid, string nnombre) {
            id = nid;
            nombre = nnombre;
            personas = new List<Persona>();
        }

    }
}
