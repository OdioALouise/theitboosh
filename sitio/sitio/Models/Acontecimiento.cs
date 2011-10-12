using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace sitio.Models
{
    public class Acontecimiento
    {
        public int AcontecimientoID { get; set; }
        public string titulo { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public DateTime fechapublicacion { get; set; }
        public string descripcion { get; set; }
        //public  Historia historia{ get; set; }
        /*
        public virtual ICollection<Sujeto> sujetos { get; set; }
        */
        public Acontecimiento(string ntitulo,  DateTime nfecha, string ndescripcion) {
            titulo = ntitulo;            
            fechapublicacion = nfecha;
            descripcion = ndescripcion;
          
        //    sujetos = new List<Sujeto>();
        }

        public Acontecimiento() {  }
        

    }
}
