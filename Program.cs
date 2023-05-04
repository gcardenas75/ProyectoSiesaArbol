using ProyectoSiesaArbol.Operaciones;

class Program
{
    static void Main(string[] args)
    {
        Operations operacionController = new Operations();

        // Creamos el árbol con peso
        Nodos raiz = new Nodos(4, 2);
        raiz.AgregarHijo(new Nodos(1, 0));
        raiz.AgregarHijo(new Nodos(2, 1));

        // Calculamos el peso del árbol
        int peso = operacionController.CalcularPeso(raiz);
        Console.WriteLine("El peso del árbol es: " + peso);
        // Calculamos el peso promedio del árbol
        double pesoPromedio = operacionController.CalcularPesoPromedio(raiz);
        Console.WriteLine("El peso promedio del árbol es: " + pesoPromedio);

        // Calculamos la altura del árbol
        int altura = operacionController.CalcularAltura(raiz);
        Console.WriteLine("La altura del árbol es: " + altura);
    }
}