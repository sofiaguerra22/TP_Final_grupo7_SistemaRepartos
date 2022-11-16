using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public class cCamioneta : cVehiculo
    {
        private int anchoAperturaPuerta;
        private int distanciaSuelo;
        public cCamioneta(int _anchoAperturaPuerta, int _distanciaSuelo) : base("Renault Kangoo Express", 7.9F, 750, 3.3F, 50)
        {
            this.anchoAperturaPuerta = _anchoAperturaPuerta;    
            this.distanciaSuelo = _distanciaSuelo;  
        }
    }
}
