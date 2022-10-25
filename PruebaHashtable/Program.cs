using System.Collections;

Hashtable openWith = new Hashtable();

// Adicionamos elementos
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");

// Mostramos los elementos
foreach(DictionaryEntry elemento in openWith)
    Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

// Intetamos colocar un elemnto con llave repetida
//openWith.Add("txt", "winword.exe");

Console.WriteLine("----");

// Cantidad de elementos
Console.WriteLine(openWith.Count);

Console.WriteLine("----");

// Obtenemos el elemento de determinada llave
Console.WriteLine(openWith["txt"]);
Console.WriteLine(openWith["xls"]);

Console.WriteLine("----");

// Colocamos elemento en una llave
openWith["txt"] = "winword.exe";
openWith["xls"] = "excel.exe"; // Esto también adiciona

foreach (DictionaryEntry elemento in openWith)
    Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

Console.WriteLine("----");

// Verificamos si hay un elemento
Console.WriteLine(openWith.Contains("xls"));
Console.WriteLine(openWith.Contains("ppt"));

Console.WriteLine("----");

// Eliminamos un elemento
openWith.Remove("xls");

foreach (DictionaryEntry elemento in openWith)
    Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

Console.WriteLine("----");

foreach(string llave in openWith.Keys)
    Console.WriteLine(llave);

Console.WriteLine("----");

foreach(string valor in openWith.Values)
    Console.WriteLine(valor);

Console.WriteLine("----");