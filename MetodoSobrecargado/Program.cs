class Program
{
    private static void Main(string[] args)
    {
        int[] arregloInt = { 1, 2, 3, 4, 5, 6 };
        double[] arregloDouble = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
        char[] arregloChar = { 'H', 'O', 'L', 'A'};

        Console.WriteLine("El arreglo arregloInt contiene:");
        ImprimirArreglo(arregloInt);
        Console.WriteLine("El arreglo arregloDouble contiene:");
        ImprimirArreglo(arregloDouble);
        Console.WriteLine("El arreglo arregloChar contiene:");
        ImprimirArreglo(arregloChar);
    }

    private static void ImprimirArreglo(char[] arregloEntrada)
    {
        foreach (char elemento in arregloEntrada)
            Console.WriteLine(elemento + " ");
        Console.WriteLine("\n");
    }

    private static void ImprimirArreglo(double[] arregloEntrada)
    {
        foreach (double elemento in arregloEntrada)
            Console.WriteLine(elemento + " ");
        Console.WriteLine("\n");
    }

    private static void ImprimirArreglo(int[] arregloEntrada)
    {
        foreach(int elemento in arregloEntrada)
            Console.WriteLine(elemento + " ");
        Console.WriteLine("\n");
    }
}