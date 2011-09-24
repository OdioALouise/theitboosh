using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class versionadoAcontecimiento
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string ubicacionGEO { get; set; }       
        public DateTime fechaPublicacion { get; set; }
        public Boolean estado { get; set; }

        public versionadoAcontecimiento(int nid, string ntitulo, string ndescripcion, string nubicacion, DateTime nfecha, Boolean nestado) {

            id = nid;
            titulo = ntitulo;
            descripcion = ndescripcion;
            ubicacionGEO = nubicacion;
            fechaPublicacion = nfecha;
            estado = nestado;


        }
    }
}
