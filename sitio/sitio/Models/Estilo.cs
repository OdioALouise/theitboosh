using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class Estilo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string colorFondo { get; set; }
        public string imagenPrincipal { get; set; }
        public string asustometro { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public string template { get; set; }
        public Historia historia { get; set; }

        public Estilo(int nid, string nnombre, string ncolorFondo, string nimagenPrincipal, string nasustometro, string ntitulo, string ncontenido, string ntemplate) {
            id = nid;
            nombre = nnombre;
            colorFondo = ncolorFondo;
            imagenPrincipal = nimagenPrincipal;
            asustometro = nasustometro;
            titulo = ntitulo;
            contenido = ncontenido;
            template = ntemplate;
        
        }
    }
}
