using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    void llenado_matriz();
    public class cLista_envios
    {
        

    }
    void llenado_matriz(List<cEnvio> lista_envios)
    {
        int[,] matriz = new int[4, 3];
        for (int i = 0; i < matriz.GetLength(0); i++) //vick esa lista se la pasamos x parametro?? Sii justo iba a hacer eso
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (j == 0)
                    matriz[i, j] = lista_envios[i].barrio;
                if (j == 1)
                    matriz[i, j] = lista_envios[i].barrio_pegado;
                if (j = 2)
                    matriz[i, j] = lista_envios[i].km //no se como hacer lo de los km

                if (j = 3)
                    matriz[i, j] = verificar_barrio(matriz[i, 0], matriz.GetLength(0));

            }
        }
}
//verifico si tengo algun pedido en ese barrio
    int verificar_barrio(int barrio, int cant, ebarrios lista_barrios)
    {
        for (int i = 0; i < cant; i++)
        {
            if (barrio == lista_barrios[i]) //supuse un enum lista de todos los barrios, no tiene que estar ordenado
                return 0;

        }
        return -1;
    }
