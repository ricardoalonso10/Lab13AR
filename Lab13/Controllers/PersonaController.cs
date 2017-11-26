using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;


namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "AV. Evergreen 322",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "AV. Progreso 322",
                FechaNac = Convert.ToDateTime("1995-11-07"),
                Email = "salasn@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "AV. Manzanos 322",
                FechaNac = Convert.ToDateTime("1992-11-07"),
                Email = "cmartinez@gmail.com"
            });
            return View(personas);
        }

        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "AV. Evergreen 322",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "AV. Progreso 322",
                FechaNac = Convert.ToDateTime("1995-11-07"),
                Email = "salasn@gmail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "AV. Manzanos 322",
                FechaNac = Convert.ToDateTime("1992-11-07"),
                Email = "cmartinez@gmail.com"
            });

            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();
            return View(persona);
        }
        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Resultado()
        {
            String nombre = Request.Form["nombre"].ToString();

            List<Persona> personas = this.listapersonas();

            Persona persona = (from p in personas
                               where p.Nombre == nombre || p.Apellido == nombre
                               select p).FirstOrDefault();

            if (!(persona == null))
            {
                return View("Mostrar", persona);
            }

            ViewData["Mensaje"] = "Persona no encontrada";

            return View("Buscar");

        }
        public List<Persona> listapersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Ricardo",
                Apellido = "Apaza",
                Direccion = "Av Salaverrt 123",
                FechaNac = Convert.ToDateTime("1998-11-07"),
                Email = "ricardo.apaza@tecsup.edu.pe"
            });

            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Alvaro ",
                Apellido = "Jimenez",
                Direccion = "Av Colon",
                FechaNac = Convert.ToDateTime("1996-11-07"),
                Email = "Alvaro.jimenez@tecsup.edu.pe"
            });

            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Fernando",
                Apellido = "Guillen",
                Direccion = "Av Dolores 234",
                FechaNac = Convert.ToDateTime("1994-11-07"),
                Email = "fernando.guillen@tecsup.edu.pe"
            });

            return personas;
        }

    }
}

    