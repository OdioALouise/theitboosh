using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class versionadoHistoria
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public Boolean estado { get; set; }
        public Persona persona { get; set; }
        public Historia historia { get; set; }


        public versionadoHistoria(int nid, string ntitulo, string ncontenido, DateTime nfecha, Boolean nestado) {

            id = nid;
            titulo = ntitulo;
            contenido = ncontenido;
            fechaPublicacion = nfecha;
            estado = nestado;
        
        }
    }
}
