using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaz;

namespace Dominio.Entidades
{
    public class ViajesYbiomas : ITematica
    {
        public Libro LibroViajes { get; set; }

        public ViajesYbiomas(Libro libroViajes)
        {
            this.LibroViajes = libroViajes; 
        }

        public void ObtenerInformacion()
        {
            LibroViajes.ObtenerInformacion(); 
        }
    }
}