using PruebaColeccionesGenericas;

/********************* Prueba List<T> *********************/
//List<int> valores = new List<int>();

//valores.Add(1);
//valores.Add(2);
//valores.Add(3);
//valores.Add(4);
//valores.Add(5);

//foreach(var valor in valores)
//    Console.WriteLine(valor);

//Console.WriteLine("------");

//Console.WriteLine(valores.Contains<int>(5));
//Console.WriteLine(valores.Contains<int>(17));

//Console.WriteLine("-----");

//Console.WriteLine(valores.IndexOf(4));

//Console.WriteLine("-----");

//valores.Insert(2, 55);

//foreach (var valor in valores)
//    Console.WriteLine(valor);

//Console.WriteLine("-----");

////valores.Remove(2);
//valores.RemoveAt(2);

//foreach (var valor in valores)
//    Console.WriteLine(valor);

//Console.WriteLine("-----");

//valores.Reverse();

//foreach (var valor in valores)
//    Console.WriteLine(valor);

//Console.WriteLine("-----");

//valores.Sort();

//foreach (var valor in valores)
//    Console.WriteLine(valor);

//Console.WriteLine("-----");

//List<Punto> listaPuntos = new List<Punto>();

//listaPuntos.Add(new Punto(5, 3));
//listaPuntos.Add(new Punto(7, 8));
//listaPuntos.Add(new Punto(12, 5));
//listaPuntos.Add(new Punto(6, 2));

//foreach(Punto punto in listaPuntos)
//    Console.WriteLine(punto);

//Console.WriteLine("-----");

//listaPuntos.Insert(2, new Punto(3, 4));

//foreach (Punto punto in listaPuntos)
//    Console.WriteLine(punto);

//Console.WriteLine("-----");

//Punto[] arregloPuntos = listaPuntos.ToArray();

//for(int i = 0; i < arregloPuntos.Length; i++)
//    Console.WriteLine(arregloPuntos[i]);

//Console.WriteLine("-----");

//listaPuntos.Sort();

//foreach(Punto punto in listaPuntos)
//    Console.WriteLine(punto);

/********************* Prueba Queue<T> *********************/

//Queue<Punto> puntos = new Queue<Punto>();

//puntos.Enqueue(new Punto(3, 7));
//puntos.Enqueue(new Punto(7, 9));
//puntos.Enqueue(new Punto(11, 2));

//foreach(Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("----------");

//// Hacemos un peek
//Console.WriteLine("Peek {0}", puntos.Peek());

//foreach (Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("----------");

//// Hacemos dequue
//Console.WriteLine("Dequeue {0}", puntos.Dequeue());
//Console.WriteLine("Dequeue {0}", puntos.Dequeue());

//foreach (Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("----------");

/********************* Prueba Stack<T> *********************/

//Stack<Punto> puntos = new Stack<Punto>();

//puntos.Push(new Punto(3, 4));
//puntos.Push(new Punto(5, 7));
//puntos.Push(new Punto(9, 11));
//puntos.Push(new Punto(1, 4));

//foreach (Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("----------");

//// Hacemos un peek
//Console.WriteLine("Peek {0}", puntos.Peek());

//foreach (Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("----------");

//// Hacemos dos pop
//Console.WriteLine("Pop {0}", puntos.Pop());
//Console.WriteLine("Pop {0}", puntos.Pop());

//foreach (Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("----------");
//// Hacemos un peek
//Console.WriteLine("Peek {0}", puntos.Peek());

//foreach (Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("----------");

/********************* Prueba HashSet<T> *********************/

//HashSet<Punto> puntos = new HashSet<Punto>();
//puntos.Add(new Punto(3, 7));
//puntos.Add(new Punto(8, 11));
//puntos.Add(new Punto(2, 6));

//foreach(Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("------------");

//puntos.Add(new Punto(1, 15));
//puntos.Add(new Punto(1, 2));

//foreach (Punto punto in puntos)
//    Console.WriteLine("->{0}", punto);

//Console.WriteLine("------------");

/********************* Prueba Dictionary<Tkey, Tvalue> *********************/

Dictionary<string, int> edades = new Dictionary<string, int>();

// Rellenar el diccionario
edades.Add("José", 18);
edades.Add("Diana", 17);
edades["María"] = 20;
edades["Pedro"] = 19;

// Recorrer el diccionario
foreach(KeyValuePair<string, int> kvp in edades)
    Console.WriteLine("Nombre: {0} Edad: {1}", kvp.Key, kvp.Value);

/********************* Prueba SortedList<Tkey, Tvalue> *********************/

SortedList<int, string> miSLista = new SortedList<int, string>();

// Adicionamos
miSLista.Add(754, "Honda");
miSLista.Add(123, "Toyota");
miSLista.Add(583, "Nissan");

// Iteramos
foreach (KeyValuePair<int, string> kvp in miSLista)
{
    Console.WriteLine("Key = {0}, Value = {1}",
        kvp.Key, kvp.Value);
}