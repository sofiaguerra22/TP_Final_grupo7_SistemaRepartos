using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPfinal
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        enum Estado { EXPRESS = 24, NORMAL= 72, DIFERIDO= 96};
        enum Zona { CABA= 1, SUR= 2, OESTE= 3, ESTE= 4 };
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new btn_Datosvehiculo());
        }
        static void guardar_vehiculos(Stack<cEnvio> pila_envios, List<cEnvio> lista_pedidos)
        {
            int i = 0;
            bool entro = false;
            while(pila_envios.Count != 0 && i < pila_envios.Count)
            {
                for(int k=0; k<pila_envios.Count; k++)
                {
                    cEnvio auxEnvio = pila_envios.Pop();
                    if (auxEnvio.barrio== lista_pedidos[k].barrio)
                    {
                        entro = vehiculo(lista_pedidos[k], camioneta);
                    }
                }
            }
        }
    }
}
