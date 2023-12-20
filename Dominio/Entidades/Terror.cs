
using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Terror : ITematica
    {
        public Libro LibroTerror { get; set; }

        public Terror(Libro libroTerror)
        {
            this.LibroTerror = libroTerror; 
        }

        public void ObtenerInformacion()
        {
            LibroTerror.ObtenerInformacion();
        }
    }
}