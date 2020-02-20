using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SubirArchivoVT.Models
{
    [Table("Personas")]

    public class Persona
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPersona { get; set; }

        [Column("Nombre")]
        public String Nombre { get; set; }

        [Column("Edad")]
        public int Edad { get; set; }

        [Column("Imagen")]
        public String Imagen { get; set; }

    }
}