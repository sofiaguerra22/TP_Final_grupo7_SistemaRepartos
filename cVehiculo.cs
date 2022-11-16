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
        public float nafta;
        public List<cEnvio> listaLlenado { get; set; }
        public cVehiculo(string _modelo, float _consumox100KM,float _cargaMax, float _volumenMax, float nafta)
        {
            this.modelo = _modelo;
            this.cargaMax = _cargaMax;
            this.carga_actual = 0;
            this.volumen_actual = 0;
            this.volumenMax = _volumenMax;
            this.consumox100KM = _consumox100KM;
            this.listaLlenado = new List<cEnvio>();
            this.ID = ID++;
            this.nafta = nafta;
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
                Console.WriteLine("hola");
            }
        }
        public bool capacidad(cArticulos a)
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
        public void contar_km_camioneta(Stack<cEnvio> Pila)
        {
            float acum = 0;
            for (int i = 0; i<Pila.Count;i++)
            {
               acum = Pila.Pop().km + acum;
                if (acum > 600)
                    cargar_nafta_camioneta();
            }
            
        }

        public void cargar_nafta_camioneta()
        {
            nafta = 50;
        }
        public void contar_km_furgoneta(Stack<cEnvio> Pila)
        {
            float acum = 0;
            for (int i = 0; i < Pila.Count; i++)
            {
                acum = Pila.Pop().km + acum;
                if (acum > 3100)
                    cargar_nafta_furgoneta();
            }

        }

        public void cargar_nafta_furgoneta()
        {
            nafta = 220;
        }
        public void contar_km_furgon(Stack<cEnvio> Pila)
        {
            float acum = 0;
            for (int i = 0; i < Pila.Count; i++)
            {
                acum = Pila.Pop().km + acum;
                if (acum > 1000)
                    cargar_nafta_furgon();
            }

        }

        public void cargar_nafta_furgon()
        {
            nafta = 90;
        }
    }
}

