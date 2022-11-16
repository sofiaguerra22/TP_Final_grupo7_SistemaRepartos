using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public class cArticulos
    {
        public int peso;
        public int largo;
        public int ancho;
        public int volumen;


        public cArticulos(int peso, int largo, int ancho)
        {
            this.peso = peso;
            this.largo = largo;
            this.ancho = ancho;
            this.volumen = largo * ancho;
        }
    }
}

