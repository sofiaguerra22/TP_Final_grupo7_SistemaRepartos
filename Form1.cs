using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPfinal
{
    public partial class btn_Datosvehiculo : Form
    {
        cVehiculo vehiculo = new cVehiculo("autito",20,30,30);
        public btn_Datosvehiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehiculo.imprimir();
        }
    }
}
