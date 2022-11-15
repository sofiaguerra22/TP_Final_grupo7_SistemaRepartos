using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    enum Estado { NOASIGNADO =0,EXPRESS = 24, NORMAL = 72, DIFERIDO = 96 };
    enum Zona { CABA = 1, SUR = 2, OESTE = 3, ESTE = 4 };
    public class cEnvio
    {
        protected string direccion;
        protected cArticulo articulo;
        Estado estado=Estado.NOASIGNADO; 
        protected bool entregado = false;

    }
}
