using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace sitio.Models
{
    public class Historia
    {
        public int HistoriaID { get; set; }
        
        public string categoria { get; set; }

        public string contenido { get; set; }


        public  virtual Acontecimiento acontecimiento { get; set; }
        public int? AcontecimientoID { get; set; }

       /* public virtual ICollection<Acontecimiento> acontecimientos { get; set; }
        public virtual ICollection<Estilo> estilos { get; set; }
        public virtual ICollection<versionadoHistoria> versionadohistoria { get; set; }
       
        public Persona persona { get; set; }
        public Asustometro austometro { get; set; }*/

        public Historia(string ncategoria, string ncontenido, Acontecimiento nacontecimiento) 
        {
         
            categoria = ncategoria;
            contenido = ncontenido;
            acontecimiento = new Acontecimiento();
            acontecimiento = nacontecimiento;

           /* acontecimientos = new List<Acontecimiento>();
            estilos = new List<Estilo>();*/
        }

        public Historia() {
        acontecimiento = new Acontecimiento();

        }

    }
}
