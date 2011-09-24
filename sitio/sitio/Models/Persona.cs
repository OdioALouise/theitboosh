using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace sitio.Models
{
    public class Persona
    {
        [Key]
        public string mail { get; set; }
        public string psw { get; set; }
        public string usuario { get; set; }
        public Boolean activado { get; set; }
        //public virtual ICollection<Historia> historias { get; set; }

        public Persona(string nmail, string npsw, string nusuario, Boolean nactivado)
        {
            mail = nmail;
            psw = npsw;
            usuario = nusuario;
            activado = nactivado;
            //historias = new List<Historia>();
        }
    }
}