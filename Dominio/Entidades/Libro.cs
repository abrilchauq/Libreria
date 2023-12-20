using Dominio.Interfaz;

namespace Dominio.Entidades;

public class Libro : ITematica
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }


    public Libro(string titulo, string autor)
    {
        this.Titulo = titulo;
        this.Autor = autor; 
    }

    public void ObtenerInformacion()
    {
        Console.WriteLine($"Titulo: {this.Titulo} - Autor: {this.Autor}");
    }
}
