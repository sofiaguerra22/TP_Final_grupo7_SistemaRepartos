using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public class cMatriz
    {
        public List<Dictionary<string,float>> listaBarrios = new List<Dictionary<string, float>>();
        public Dictionary<string, float> Liniers = new Dictionary<string, float>();
        public Dictionary<string, float> Versalles = new Dictionary<string, float>();
        public Dictionary<string, float> Villa_Luro = new Dictionary<string, float>();
        public Dictionary<string, float> Mataderos = new Dictionary<string, float>(); 
        public Dictionary<string, float> Villa_Real = new Dictionary<string, float>();
       
        public int Verificar(string barrio)
        {
            int cant = listaBarrios.Count;
            for (int i = 0; i < cant; i++)
            {
                if (barrio == )
                    return 0;
            }
            return -1;
        }
        public void llenado()
        {
            listaBarrios.Add(Liniers);
            Liniers.Add("Versalles", 4);
            Liniers.Add("Villa_Luro", 2);
            Liniers.Add("Mataderos", 2.2F);
            Liniers.Add("Tres_de_febrero", 6);
            listaBarrios.Add(Versalles);
            Versalles.Add("Liniers", 4);
            Versalles.Add("Villa_Real", 1.7F);
            Versalles.Add("Monte_Castro", 2.4F);
            Versalles.Add("Villa_Luro", 2.1F);
            listaBarrios.Add(Villa_Luro);
            Villa_Luro.Add("Versalles", 2.1F);
            Villa_Luro.Add("Liniers", 2);
            Villa_Luro.Add("Monte_Castro", 3.3F);
            Villa_Luro.Add("Velez", 1.7F);
            Villa_Luro.Add("Parque_Avellaneda", 2.5F);
            Villa_Luro.Add("Mataderos", 3.7F);
            listaBarrios.Add(Mataderos);
            Villa_Luro.Add("Liniers", 2.2F);
            Villa_Luro.Add("Villa_Luro", 3.7F);
            Villa_Luro.Add("Parque_Avellaneda", 2.3F);
            Villa_Luro.Add("Villa_Lugano", 2.7F);
            listaBarrios.Add(Mataderos);
            Villa_Luro.Add("Versalles", 1.7F);
            Villa_Luro.Add("Villa_Devoto", 3.3F);
            Villa_Luro.Add("Monte_Castro", 2.3F);
        }
    }
}