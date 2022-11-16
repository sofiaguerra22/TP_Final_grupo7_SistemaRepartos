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
        public cArticulo articulo;
        public Estado estado = 0;
        public bool entregado = false;
        public string barrio;
        public float km { get; set; }

        public cEnvio(string direccion, cArticulo articulo, Estado estado, bool entregado, string barrio)
        {
            this.direccion = direccion;
            this.articulo = articulo;
            this.estado = estado;
            this.entregado = entregado;
            this.barrio = barrio;
        }
        public Stack<cEnvio> recorrido(List<cEnvio> listaEnvios, List<Dictionary<string, float>> listaBarrios)
        {
            int pos = 0;
            Stack<cEnvio> aux = new Stack<cEnvio>();
            for (int i = 0; i < listaBarrios.Count; i++)
            {
                for (int x = 0; x < listaBarrios[i].Count - 1; x++)
                {
                    if (listaBarrios[i].Keys.ElementAt(x) == listaEnvios[i].barrio)
                    {
                        if (x == 0)
                            pos = x;

                        if (listaBarrios[i].Values.ElementAt(x) < listaBarrios[i].Values.ElementAt(x + 1))
                        {
                             pos = x;
                        }
                    }
                }
                for(int y = 0; y < listaBarrios.Count; y++) {
                    if(listaEnvios[y].barrio == listaBarrios[y].Keys.ElementAt(pos)) 
                    {
                        aux.Push(listaEnvios[y]);
                        listaEnvios[y].km = listaBarrios[y].Values.ElementAt(pos);
                    }
                }
            }
            return aux;

        }
    }

    
}
