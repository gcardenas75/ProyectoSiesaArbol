using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSiesaArbol.Operaciones
{
    public class Nodos
    {
        public int Peso { get; set; }
        public Nodos[] Hijos { get; set; }

        public Nodos(int peso, int cantidadHijos)
        {
            Peso = peso;
            Hijos = new Nodos[cantidadHijos];
        }

        public void AgregarHijo(Nodos hijo)
        {
            for (int i = 0; i < Hijos.Length; i++)
            {
                if (Hijos[i] == null)
                {
                    Hijos[i] = hijo;
                    return;
                }
            }

            throw new Exception("No se pueden agregar más hijos al nodo");
        }
    }

}
