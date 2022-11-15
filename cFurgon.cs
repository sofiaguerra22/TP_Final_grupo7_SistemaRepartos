using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public class cFurgon: cVehiculo
    {
        private const float ahorroCombustible = 0.4F;
        
        public cFurgon() : base("Iveco Daily", 9.048F, 4900F, 10.8F) { }
    }
}
