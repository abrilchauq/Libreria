using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Antropologia : ITematica
    {
        public Libro LibroAntro { get; set; }

        public Antropologia(Libro libroAntro)
        {
            this.LibroAntro = libroAntro;
        }

        public void ObtenerInformacion()
        {
            LibroAntro.ObtenerInformacion(); 
        }
    }
}