using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public class cPrueba
    {
        public Dictionary<string, Dictionary> Barrios = new Dictionary<string, Dictionary>();
        public Dictionary<string, float> Versalles = new Dictionary<string, float>();
        public Dictionary<string, float> Villa_Luro = new Dictionary<string, float>();
        public Dictionary<string, float> Mataderos = new Dictionary<string, float>();
        public Dictionary<string, float> Villa_Real = new Dictionary<string, float>();

        public cBarrios()
        {
            llenado();
        }

        public void llenado()
        {
            Barrios.Add("Versalles", Versalles);
            Versalles.Add("Liniers", 4);
            Versalles.Add("Villa_Real", 1.7F);
            Versalles.Add("Monte_Castro", 2.4F);
            Versalles.Add("Villa_Luro", 2.1F);
            Barrios.Add("Villa_Luro", Villa_Luro);
            Villa_Luro.Add("Versalles", 2.1F);
            Villa_Luro.Add("Liniers", 2);
            Villa_Luro.Add("Monte_Castro", 3.3F);
            Villa_Luro.Add("Velez", 1.7F);
            Villa_Luro.Add("Parque_Avellaneda", 2.5F);
            Villa_Luro.Add("Mataderos", 3.7F);
            Barrios.Add("Mataderos",Mataderos);
            Mataderos.Add("Liniers", 2.2F);
            Mataderos.Add("Villa_Luro", 3.7F);
            Mataderos.Add("Parque_Avellaneda", 2.3F);
            Mataderos.Add("Villa_Lugano", 2.7F);
            Barrios.Add("Villa Real", Villa_Real);
            Villa_Real.Add("Versalles", 1.7F);
            Villa_Real.Add("Villa_Devoto", 3.3F);
            Villa_Real.Add("Monte_Castro", 2.3F);
        }
    }
}
