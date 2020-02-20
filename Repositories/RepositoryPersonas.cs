using SubirArchivoVT.Data;
using SubirArchivoVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubirArchivoVT.Repositories
{
    public class RepositoryPersonas
    {
        ConexionPersonas context;

        public RepositoryPersonas() {
            context = new ConexionPersonas();
        }

        public Persona GetPersona(int id)
        {
            return context.Personas.SingleOrDefault(z=>z.IdPersona == id);
        }

        public void GuardarImagenPersona(int id,String NombreImagen)
        {
            Persona per = GetPersona(id);
            per.Imagen = NombreImagen;
            context.SaveChanges();
        }



    }
}