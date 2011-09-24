using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class Acontecimiento
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string ubicacionGEO { get; set; }
        public DateTime fechapublicacion { get; set; }
        public string descripcion { get; set; }
        public Historia historia;
        public virtual ICollection<Sujeto> sujetos { get; set; }

        public Acontecimiento(int nid, string ntitulo, string nubicacion, DateTime nfecha, string ndescripcion) {
            id = nid;
            titulo = ntitulo;
            ubicacionGEO = nubicacion;
            fechapublicacion = nfecha;
            descripcion = ndescripcion;
            sujetos = new List<Sujeto>();
        }


    }
}
