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

    }
}
