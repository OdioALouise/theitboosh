using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Historia h = new Historia(1, "Horror show", "Horrores", "Relato oficial", DateTime.Now);

            System.Console.WriteLine("Creamos una historia: \n Identificador: " + h.id + "\n Fecha de creacion" + h.fechapublicacion + "\n Categoria" + h.categoria +"\n Titulo: " + h.titulo + "\n Contenido: " + h.contenido);

            Acontecimiento a = new Acontecimiento(1, "Acon.1", "-125.123654,456.664221", DateTime.Now, "Hola descripcion");

            System.Console.WriteLine("\n Acontecimiento: \n Identificador:" + a.id + "\n Fecha del acontecimiento: " + h.fechapublicacion +"\n Titulo: " + h.titulo + "\n Ubicacion: " + a.ubicacionGEO + "\n Descripcion: " + a.descripcion);

            a.historia = h;

            h.acontecimientos.Add(a);
            h.acontecimiento = a;
            System.Console.WriteLine("\n Se ha asociado la historia: " + a.historia.titulo + " al acontecimiento: " + h.acontecimientos.ElementAt(0).titulo);

            Sujeto s = new Sujeto(1, "Foto1", "Esta foto es de la corona", "c:/imagenes/jui.jpg");

            System.Console.WriteLine("\n Creose un sujeto \n Identificador: " + s.id + "\n Nombre: " + s.nombre + "\n Descripcion: " + s.descripcion + "\n URL: " + s.url);

            s.acontecimiento = a;

            a.sujetos.Add(s);

            System.Console.WriteLine("\n Se agrego un sujeto al acontecimiento: " + s.acontecimiento.titulo + " el sujeto es: " + a.sujetos.ElementAt(0).nombre );


            Estilo e = new Estilo(1, "Estilo1", "#12adsa", "c:/gpir.bmp", "style{}", "style{}", "style{}", "terror.css");

            System.Console.WriteLine("\n Se agrego un estilo: \n Nombre del estilo: " + e.nombre);

            h.estilos.Add(e);

            e.historia = h;

            Persona p = new Persona("Jesus@hotmail.com", "123456", "jorge1982", true);

            System.Console.WriteLine("\n Nuevo usuario creado \n Nombre: " + p.usuario);

            p.historias.Add(h);

            h.persona = p;

            Donacion d = new Donacion(1255, "Aguante la pagina", DateTime.Now);
            d.monto = 125.65;

            System.Console.WriteLine("\n Donacion hecha \n Cantidad: $" + d.monto);

            Asustometro asus = new Asustometro();

            Rol r = new Rol(1, "Moderador");

            System.Console.WriteLine("\n Rol creado \n Nombre: " + r.nombre);

            versionadoHistoria vh = new versionadoHistoria(1, "Cambio titulo", "cambio contenido", DateTime.Now, true);
            vh.persona = p;
            vh.historia = h;
            System.Console.WriteLine("\n Versionado de Historia \n Titulo: " + vh.titulo);

            versionadoAcontecimiento va = new versionadoAcontecimiento(1, "Version1", "Descripcion1", "-123.1254,-725255", DateTime.Now, false);

            System.Console.WriteLine("\n Versionado de Acontecimiento \n Version: " + va.titulo);
        }
    }
}
