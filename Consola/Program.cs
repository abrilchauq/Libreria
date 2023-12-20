using Dominio.Entidades;
using Dominio.Interfaz;

List<Libro> ListaLibros = new List<Libro>();

Estante estante1 = new Estante();
Estante estante2 = new Estante();
Estante estante3 = new Estante();
Estante estante4 = new Estante();
Estante estante5 = new Estante();

Libro libroC = new Libro("Introduccion a c#", "John Doe");
Libro libroC2 = new Libro("Python", "Desconocido");
ListaLibros.Add(libroC2);
ListaLibros.Add(libroC);
ITematica computacion = new Computacion(libroC);
ITematica computacion2 = new Computacion(libroC2);

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

estante1.AgregarLibro(computacion);
estante1.AgregarLibro(computacion2);
estante2.AgregarLibro(novela);
estante3.AgregarLibro(deportes);
estante4.AgregarLibro(historia);
estante5.AgregarLibro(terror);

Console.WriteLine($"Estante computación: ");
estante1.MostrarLibros();

Console.WriteLine($"Estante novelas: ");
estante2.MostrarLibros();

Console.WriteLine($"Estante deportes: ");
estante3.MostrarLibros();

Console.WriteLine($"Estante historia: ");
estante4.MostrarLibros();

Console.WriteLine($"Estante terror: ");
estante5.MostrarLibros();

