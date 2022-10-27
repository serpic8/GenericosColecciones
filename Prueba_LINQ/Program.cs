//1. Obtener el origen de datos
using Prueba_LINQ;

int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6 };

//2. Crear la consulta
//numPares es un IEnumerable<int>

IEnumerable<int> numPares = from num in numeros  //Este codigo es para comprobar los numeros pares 
                            where num % 2 == 0
                            select num;

//3. Ejecutar la consulta
foreach(int num in numPares)
    Console.Write("{0,1}", num);

Console.WriteLine("----------------");
ControlEmpleadosEmpresa cee = new ControlEmpleadosEmpresa();
Console.WriteLine("Obtener CEO");
cee.ObtenerCEO();

int empresa = 4;
Console.WriteLine("Obtener empleados de empresa "+empresa);
cee.ObtenerEmpleadosEmpresa(empresa);

//Dio mio q rapido explica, copia de github de nuevo