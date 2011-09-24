using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class Historia
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string categoria { get; set; }
        public string contenido { get; set; }
        public DateTime fechapublicacion { get; set; }
        public virtual ICollection<Acontecimiento> acontecimientos { get; set; }
        public virtual ICollection<Estilo> estilos { get; set; }
        public virtual ICollection<versionadoHistoria> versionadohistoria { get; set; }
        public Acontecimiento acontecimiento { get; set; }
        public Persona persona { get; set; }
        public Asustometro austometro { get; set; }

        public Historia(int identificador, string ntitulo, string ncategoria, string ncontenido, DateTime nfecha) 
        {
            id = identificador;
            titulo = ntitulo;
            categoria = ncategoria;
            contenido = ncontenido;
            fechapublicacion = nfecha;
            acontecimientos = new List<Acontecimiento>();
            estilos = new List<Estilo>();
        }



    }
}
