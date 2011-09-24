using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class Sujeto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string url { get; set; }
        public Acontecimiento acontecimiento;


        public Sujeto(int nid, string nnombre, string ndescripcion, string nurl) {
            id = nid;
            nombre = nnombre;
            descripcion = ndescripcion;
            url = nurl;        
        }

    }
}
