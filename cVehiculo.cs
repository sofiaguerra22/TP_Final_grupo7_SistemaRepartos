using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public class cVehiculo
    {
        public readonly uint ID;
        protected string modelo;
        protected float consumox100KM;
        protected float cargaMax;
        protected float carga_actual;
        protected float volumen_actual;
        protected float volumenMax;
        public List<cEnvio> listaLlenado { get; set; }
        public cVehiculo(string _modelo, float _consumox100KM,float _cargaMax, float _volumenMax)
        {
            this.modelo = _modelo;
            this.cargaMax = _cargaMax;
            this.carga_actual = 0;
            this.volumen_actual = 0;
            this.volumenMax = _volumenMax;
            this.consumox100KM = _consumox100KM;
            this.listaLlenado = new List<cEnvio>();
            this.ID = ID++;
        }
        public void imprimir()
        {
            System.Windows.Forms.MessageBox.Show("Datos del siguiente vehiculo!");
        }

        public void guardar_vehiculos(Stack<cEnvio> pila_envios)
        {
            int i = 0;
            bool entro = false;
            while (pila_envios.Count != 0 && i < pila_envios.Count)
            {
                cEnvio auxEnvio = pila_envios.Pop();
                entro = capacidad(auxEnvio.articulo);
                listaLlenado.Add(auxEnvio);
                i++;
            }
        }
        public bool capacidad(cArticulo a)
        { //a es el articulo de la lista del vehiculo
            carga_actual=carga_actual + a.peso;
            if (carga_actual < cargaMax)
            {
                volumen_actual = volumen_actual + a.volumen;
                if (volumen_actual < volumenMax)
                {
                    return true;
                }
                else
                    return false;
            }
            else return false;
        }
        public void ordenar_prioridad()
        { 
            for(int k=0; k< listaLlenado.Count-1 ; k++)
            {
                for (int i = 0; i < listaLlenado.Count - 1; i++)
                {
                    if(listaLlenado[i].estado> listaLlenado[i + 1].estado)
                    {
                        cEnvio aux;
                        aux = listaLlenado[i];
                        listaLlenado[i] = listaLlenado[i + 1];
                        listaLlenado[i + 1] = aux;
                    }
                }
            }
        }
    }
}
