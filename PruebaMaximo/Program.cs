Console.WriteLine("El máximo de {0}, {1} y {2} es {3}\n",
    3, 4, 5, Maximo(3, 4, 5));
Console.WriteLine("El máximo de {0}, {1} y {2} es {3}\n",
    6.6, 8.8, 7.7, Maximo(6.6, 8.8, 7.7));
Console.WriteLine("El máximo de {0}, {1} y {2} es {3}\n",
    "pera", "manzana", "naranja", 
    Maximo("pera", "manzana", "naranja"));

T Maximo<T>(T x, T y, T z) where T : IComparable<T>
{
    T max = x; // supone que al principio x es el mayor

    // compara y con max
    if(y.CompareTo(max) > 0)
        max = y; // y es el mayor hasta ahora

    // compara z con max
    if(z.CompareTo(max) > 0)
        max=z; // z es el mayor

    return max; // devuelve el objeto mayor
}