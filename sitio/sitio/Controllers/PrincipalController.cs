using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using sitio.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace sitio.Controllers
{
    public class PrincipalController : Controller
    {
        //
        // GET: /Principal/

        private mapeoDBContext db = new mapeoDBContext();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Historia()
        {
            return View();
        }

       
        public JArray traerArreglo() {


            JArray arreglo = new JArray();
            
            List<Historia> historiaPrincipales = new List<Historia>();
            List<Acontecimiento> lac = new List<Acontecimiento>();

            historiaPrincipales = db.historias.Where(a => a.HistoriaID > 0).ToList();

            int elementos = historiaPrincipales.Count;

            int contador = 0;

            while (contador < elementos) 
                    {
                   

                JObject o = new JObject();
                
                    o.Add("categoria", new JValue(historiaPrincipales[contador].categoria));
  
                    o.Add("contenido", new JValue(historiaPrincipales[contador].contenido));

                int valor =(int) historiaPrincipales[contador].AcontecimientoID;

                lac = db.acontecimientos.Where(ac => ac.AcontecimientoID == valor).ToList();

                       
                    o.Add("titulo", new JValue(lac[0].descripcion));

                    o.Add("descripcion", new JValue(lac[0].descripcion));

                    o.Add("fecha", new JValue(lac[0].fechapublicacion));

                    o.Add("geolat", new JValue(lac[0].latitud));

                    o.Add("geolon", new JValue(lac[0].longitud));

                       arreglo.Add(o);

                contador++;
                    }
            Dispose(true);
            return arreglo;        
        }



           protected override void Dispose(bool disposing)
{
    db.Dispose();
    base.Dispose(disposing);
}

      



    }
}
