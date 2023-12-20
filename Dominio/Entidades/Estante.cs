using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Estante
    {
        public List<ITematica> libros;

        public Estante()
        {
            libros = new List<ITematica>();
        }

        public void AgregarLibro(ITematica libro)
        {
            libros.Add(libro);
        }

        public void MostrarLibros()
        {
            foreach (var libro in libros)
            {
                libro.ObtenerInformacion();
            }
        }

        public List<ITematica> ObtenerLibros()
        {
            return libros;
        }
    }
}