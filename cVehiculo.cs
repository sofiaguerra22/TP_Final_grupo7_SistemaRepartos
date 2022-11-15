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
        protected float volumenMax;
        public List<cEnvio> listaLlenado { get; set; }
        public cVehiculo(string _modelo, float _consumox100KM,float _cargaMax, float _volumenMax)
        {
            this.modelo = _modelo;
            this.cargaMax = _cargaMax;
            this.volumenMax = _volumenMax;
            this.consumox100KM = _consumox100KM;
            this.listaLlenado = new List<cEnvio>();
            this.ID = ID++;
        }
        public void imprimir()
        {
            System.Windows.Forms.MessageBox.Show("Datos del siguiente vehiculo!");
        }

        
    }
}
