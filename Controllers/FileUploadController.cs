using SubirArchivoVT.Models;
using SubirArchivoVT.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubirArchivoVT.Controllers
{
    public class FileUploadController : Controller
    {
        RepositoryPersonas repo;
        public FileUploadController() {
            this.repo = new RepositoryPersonas();
        }
        // GET: FileUpload
        public ActionResult SubirArchivo()
        {
            Persona persona = repo.GetPersona(1);

            return View(persona);
        }

        [HttpPost]
        public ActionResult SubirArchivo(HttpPostedFileBase file)
        {
            Persona persona = repo.GetPersona(1);

            String NombreImagen = persona.IdPersona+"."+file.FileName;

            file.SaveAs(Server.MapPath("~/ImagenesSubidas/") + NombreImagen);



            repo.GuardarImagenPersona(1, NombreImagen);

            return View(persona);
        }



    }
}