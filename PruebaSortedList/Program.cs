using System.Collections;

SortedList miSLista = new SortedList();

// Adicionamos
miSLista.Add(754, "Honda");
miSLista.Add(123, "Hyundai");
miSLista.Add(587, "Toyota");
miSLista.Add(323, "Mazda");

// Iteramos
foreach(DictionaryEntry elemento in miSLista)
    Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

Console.WriteLine("------------");

// Cantidad de elementos
Console.WriteLine(miSLista.Count);

// Contiene elemento
Console.WriteLine(miSLista.Contains(123));
Console.WriteLine(miSLista.Contains(678));

Console.WriteLine(miSLista.ContainsKey(587));
Console.WriteLine(miSLista.ContainsValue("Toyota"));

Console.WriteLine("------------");

// Obtenemos elemento por índice
Console.WriteLine(miSLista.GetKey(2));
Console.WriteLine(miSLista.GetByIndex(2));
