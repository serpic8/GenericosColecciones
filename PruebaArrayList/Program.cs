using System.Collections;

ArrayList colores1 = new ArrayList();

colores1.AddRange(new string[] { "magenta", "rojo", "blanco" });
colores1.Add("azul");
colores1.Add("cyan");
colores1.Add("amarillo");
colores1.Add("verde");
colores1.Add("celeste");
colores1.Add("blanco");

Console.WriteLine("Cantidad de elementos en el ArrayList es {0}",
    colores1.Count);
Console.WriteLine("Capacidad del ArrayList es {0}",
    colores1.Capacity);

for (int i = 0; i < colores1.Count; i++)
    Console.Write(" {0}", colores1[i]);

Console.WriteLine();
Console.WriteLine("-------------");

foreach(string color in colores1)
    Console.Write(" {0}", color);


Console.WriteLine();
Console.WriteLine("-------------");

int[] numeros = { 2, 4, 6, 7, 8 };

ArrayList valores = new ArrayList();

foreach(int i in numeros)
    valores.Add(i);

// Vemos si existe un elemnto en el ArrayList
Console.WriteLine(valores.Contains(5));
Console.WriteLine(valores.Contains(2));
Console.WriteLine("-------------");

// Insertamos en un índice en particular
valores.Insert(2, 55);

for(int i = 0; i < valores.Count; i++)
    Console.WriteLine(valores[i]);

Console.WriteLine();
Console.WriteLine("-------------");

// Removemos
valores.Remove(55);

for (int i = 0; i < valores.Count; i++)
    Console.WriteLine(valores[i]);

Console.WriteLine();
Console.WriteLine("-------------");

// Removemos en una posición
valores.RemoveAt(0);

for (int i = 0; i < valores.Count; i++)
    Console.WriteLine(valores[i]);

Console.WriteLine();
Console.WriteLine("-------------");

/***********************************************************/

string[] colores = { "magenta", "rojo", "blanco", "azul", "cyan"};
string[] eliminarColores = { "rojo", "blanco", "azul" };

ArrayList lista = new ArrayList();

foreach(string color in colores)
    lista.Add(color);

ArrayList eliminarLista = new ArrayList(eliminarColores);
Console.WriteLine("ArrayList: ");
MostrarInformacion(lista);

EliminarColores(lista, eliminarLista);

Console.WriteLine("\nArrayList después de llamar " +
    "a EliminarColores...");
MostrarInformacion(lista);

void MostrarInformacion(ArrayList arregloLista)
{
    foreach(object elemento in arregloLista)
        Console.WriteLine("{0} ", elemento);
    Console.WriteLine("\nTamaño = {0}; Capacidad = {1}",
        arregloLista.Count, arregloLista.Capacity);

    int index = arregloLista.IndexOf("azul");

    if(index != -1)
        Console.WriteLine("El arreglo lista contiene azul " +
            "en el índice {0}.", index);
    else
        Console.WriteLine("El arreglo lista no contiene azul.");
}


void EliminarColores(ArrayList primeraLista, ArrayList segundaLista)
{
    for(int i = 0; i < segundaLista.Count; i++)
        primeraLista.Remove(segundaLista[i]);
}