using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public enum Estado { NOASIGNADO =0,EXPRESS = 24, NORMAL = 72, DIFERIDO = 96 };
    public class cEnvio
    { 
        public string direccion;
        public cArticulos articulo;
        public Estado estado = 0;
        public bool entregado = false;
        public string barrio;
        public float km { get; set; }

        public cEnvio(string direccion, cArticulos articulo, Estado estado, bool entregado, string barrio)
        {
            this.direccion = direccion;
            this.articulo = articulo;
            this.estado = estado;
            this.entregado = entregado;
            this.barrio = barrio;
        }
        public Stack<cEnvio> recorrido(List<cEnvio> listaEnvios, Dictionary<string, Dictionary<string,float>>listaBarrios)
        {
            int pos = 0;
            Stack<cEnvio> aux = new Stack<cEnvio>();
            for (int i = 0; i < listaBarrios.Count; i++)
            {
                for (int x = 0; x < listaBarrios.Values.Count-1; x++)
                {
                    if (listaBarrios.ElementAt(i).Key==(listaEnvios[i].barrio))
                    {
                        if (listaBarrios.ElementAt(i).Value.ElementAt(x).Value< listaBarrios.ElementAt(i).Value.ElementAt(x + 1).Value)
                        {
                             pos = x;
                        }
                    }
                }
                for(int y = 0; y < listaBarrios.Count; y++) {
                    if(listaEnvios[y].barrio == listaBarrios.ElementAt(y).Value.ElementAt(pos).Key) 
                    {
                        aux.Push(listaEnvios[y]);
                        listaEnvios[y].km = listaBarrios.ElementAt(y).Value.ElementAt(pos).Value;
                    }
                }
            }
            return aux;

        }
    }

    
}
