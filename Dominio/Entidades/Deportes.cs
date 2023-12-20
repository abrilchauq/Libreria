using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class Deportes : ITematica
    {

        public Libro LibroDeporte { get; set; }

        public Deportes(Libro libroDeporte)
        {
            this.LibroDeporte = libroDeporte; 
        }
        public void ObtenerInformacion()
        {
            LibroDeporte.ObtenerInformacion(); 
        }
    }
}