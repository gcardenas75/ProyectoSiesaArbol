using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSiesaArbol.Operaciones
{
    public class Operations
    {
        public int CalcularPeso(Nodos nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            else
            {
                int peso = nodo.Peso;
                foreach (Nodos hijo in nodo.Hijos)
                {
                    peso += CalcularPeso(hijo);
                }
                return peso;
            }
        }
        public double CalcularPesoPromedio(Nodos nodo)
        {
            int cantidadNodos = ContarNodos(nodo);
            int pesoTotal = CalcularPeso(nodo);
            return (double)pesoTotal / cantidadNodos;
        }


        public int ContarNodos(Nodos nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            else
            {
                int contador = 1;
                foreach (Nodos hijo in nodo.Hijos)
                {
                    contador += ContarNodos(hijo);
                }
                return contador;
            }
        }

        public int CalcularAltura(Nodos nodo)
        {
            if (nodo == null)
            {
                return -1;
            }
            else
            {
                int maximoAlturaHijos = 0;
                foreach (Nodos hijo in nodo.Hijos)
                {
                    int alturaHijo = CalcularAltura(hijo);
                    if (alturaHijo > maximoAlturaHijos)
                    {
                        maximoAlturaHijos = alturaHijo;
                    }
                }
                return 1 + maximoAlturaHijos;
            }
        
        }
    }
}



