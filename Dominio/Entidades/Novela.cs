using Dominio.Interfaz;

namespace Dominio.Entidades;

public class Novela : ITematica
{
    public Libro LibroNovela { get; set; }

    public Novela(Libro libroNovela)
    {
        this.LibroNovela = libroNovela; 
    }

    public void ObtenerInformacion()
    {
        LibroNovela.ObtenerInformacion(); 
    }
}
