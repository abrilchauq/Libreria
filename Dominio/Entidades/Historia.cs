using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Historia : ITematica
    {

        public Libro LibroHistoria { get; set; }

        public Historia(Libro libroHistoria)
        {
            this.LibroHistoria = libroHistoria;             
        }
        public void ObtenerInformacion()
        {
            throw new NotImplementedException();
        }
    }
}