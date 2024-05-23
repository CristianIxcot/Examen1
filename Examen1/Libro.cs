using System.ComponentModel.DataAnnotations;
namespace Examen1
{
    public class Libro
    {
        [Required(ErrorMessage = "EL Titulo es Requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "EL Autor es Requerido")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "EL Genero es Requerido")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "EL Año de publicacion es Requerido")]
        public int Anio { get; set; }

        public Libro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            Anio = 0;

        }
    }
}
