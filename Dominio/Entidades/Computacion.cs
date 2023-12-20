using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Computacion : ITematica
    {
        public Libro LibroComputacion { get; set; }

        public Computacion(Libro libroComputacion)
        {
            this.LibroComputacion = libroComputacion; 
        }

        public void ObtenerInformacion()
        {
            LibroComputacion.ObtenerInformacion();
        }


    }
}