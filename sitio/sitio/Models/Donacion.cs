using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sitio.Models
{
    public class Donacion
    {
        public double monto { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaDonacion { get; set; }

        public Donacion(float nmonto, string ndescripcion, DateTime nfecha) {

            monto = nmonto;
            descripcion = ndescripcion;
            fechaDonacion = nfecha;
        
        }
            
    }
}
