
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPfinal
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        [STAThread]
        static public void ordenar_prioridad(List<cEnvio> listaLlenado)
        {
            for (int k = 0; k < listaLlenado.Count - 1; k++)
            {
                for (int i = 0; i < listaLlenado.Count - 1; i++)
                {
                    if (listaLlenado[i].estado > listaLlenado[i + 1].estado)
                    {
                        cEnvio aux;
                        aux = listaLlenado[i];
                        listaLlenado[i] = listaLlenado[i + 1];
                        listaLlenado[i + 1] = aux;
                    }
                }
            }
        }
        static public Stack<cEnvio> recorrido(List<cEnvio> listaEnvios, Dictionary<string, Dictionary<string,float>>listaBarrios)
        {
            int pos = 0;
            Stack<cEnvio> aux = new Stack<cEnvio>();
            for (int i = 0; i < listaBarrios.Count; i++)
            {
                for (int x = 0; x < listaBarrios.ElementAt(i).Value.Count-1; x++)
                {
                    Console.WriteLine("Esta entrando");
                    if (listaBarrios.ElementAt(i).Key==(listaEnvios[i].barrio))
                    {
                        Console.WriteLine("Esta entrando");
                        if (listaBarrios.ElementAt(i).Value.ElementAt(x).Value < listaBarrios.ElementAt(i).Value.ElementAt(x + 1).Value)
                        {
                             pos = x;
                             aux.Push(listaEnvios[i]);
                             Console.WriteLine("SE ESTA LLENANDO LA PILAAAAAAA");
                             listaEnvios[i].km = listaBarrios.ElementAt(i).Value.ElementAt(pos).Value;
                        }
                    }
                }
                //lo de aca abajo me estaba tirando error asi q lo meti dentro de la funcion y a la mierda, capaz esta mal pero me tiraba exception la condicion del if
                /*for(int y = 0; y < listaBarrios.Count; y++) {
                    if (listaBarrios.ElementAt(y).Value.ElementAt(pos).Key.Contains(listaEnvios[y].barrio))
                    {
                        aux.Push(listaEnvios[y]);
                        Console.WriteLine("SE ESTA LLENANDO LA PILAAAAAAA");
                        listaEnvios[y].km = listaBarrios.ElementAt(y).Value.ElementAt(pos).Value;
                    }
                }*/
            }
            return aux;

        }
        static public void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new btn_Datosvehiculo());
            //Creo mis 3 vehiculos que se van a encargar de repartir
            cCamioneta camioneta = new cCamioneta(90,60);
            cFurgoneta furgoneta = new cFurgoneta();
            cFurgon furgon = new cFurgon();

            //Creo mis articulos 
            cArticulos art1 = new cArticulos(3, 3, 3);
            cArticulos art2 = new cArticulos(2, 3, 2);
            cArticulos art3 = new cArticulos(1, 1, 1);
            cArticulos art4 = new cArticulos(2, 1, 3);

            //Creo mis Envios
            cEnvio envio1 = new cEnvio("banana 1", art1, Estado.NOASIGNADO, false, "Liniers");
            cEnvio envio2 = new cEnvio("banana 2", art2, Estado.NOASIGNADO, false, "Villa_Luro");
            cEnvio envio3 = new cEnvio("banana 3", art3, Estado.NOASIGNADO, false, "Mataderos");
            cEnvio envio4 = new cEnvio("banana 4", art4, Estado.NOASIGNADO, false, "Villa_Real");

            //Creo mi lista de envios
            List<cEnvio> listaEnvios = new List<cEnvio>();
            listaEnvios.Add(envio1);
            listaEnvios.Add(envio2);
            listaEnvios.Add(envio3);
            listaEnvios.Add(envio4);

            //arranco funcionamiento programa
            Stack<cEnvio> pilaOrdenada = new Stack<cEnvio>();
            ordenar_prioridad(listaEnvios);
            //me creo un cBarrios para acceder a la lista total de barrios
            cBarrios Barrios = new cBarrios();
            //cPrueba prueba = new cPrueba();
            pilaOrdenada = recorrido(listaEnvios,Barrios.Barrios);

            //pruebo en cada vehiculo 1 por 1 si entran los objetos de la lista.
            camioneta.guardar_vehiculos(pilaOrdenada);
            furgoneta.guardar_vehiculos(pilaOrdenada);
            furgon.guardar_vehiculos(pilaOrdenada);

            furgoneta.cargar_nafta_furgoneta();
            furgon.cargar_nafta_furgon();
            camioneta.cargar_nafta_camioneta();
         }
    }
}
