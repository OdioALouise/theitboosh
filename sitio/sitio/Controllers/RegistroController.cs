using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sitio.Models;

namespace sitio.Controllers
{
    public class RegistroController : Controller
    {
        //
        // GET: /Registro/
        public mapeoDBContext db = new mapeoDBContext();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Alta(string email, string pass, string usu)
        {
            Persona p = new Persona(email, pass, usu, true);
            db.personas.Add(p);
            db.SaveChanges();
            return "Holi" + email+pass+usu;

        }

    }
}
