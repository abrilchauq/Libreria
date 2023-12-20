using Dominio.Entidades;
using Dominio.Interfaz;

List<Libro> ListaLibros = new List<Libro>();

Estante estante = new Estante();

Libro libroC = new Libro("Introduccion a c#", "John Doe");
ListaLibros.Add(libroC);
ITematica computacion = new Computacion(libroC);

Libro libroN = new Libro("Harry Potter: El caliz de fuego", "J.K Rowling");
ListaLibros.Add(libroN);
ITematica novela = new Novela(libroN);

Libro libroD = new Libro("Historia del futbol", "Desconocido");
ListaLibros.Add(libroD);
ITematica deportes = new Deportes(libroD);

Libro libroH = new Libro("Historia 5°", "Santillana");
ListaLibros.Add(libroH);
ITematica historia = new Deportes(libroH);

Libro libroT = new Libro("El visitante", "Stephen King");
ListaLibros.Add(libroT);
ITematica terror = new Deportes(libroT);

estante.AgregarLibro(computacion);
estante.AgregarLibro(novela);
estante.AgregarLibro(deportes);
estante.AgregarLibro(historia);
estante.AgregarLibro(terror);

Console.WriteLine("------------------");
Console.WriteLine("LIBROS EN ESTANTES: ");
Console.WriteLine("------------------");
foreach (var libro in estante.ObtenerLibros())
{
    libro.ObtenerInformacion();
}