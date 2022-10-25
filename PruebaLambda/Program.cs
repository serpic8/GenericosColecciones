List<int> numeros = new List<int>();

numeros.AddRange(new int[] {1,2,3,4,5,6,7,8});

//Hacemos uso de la expresion lambda
//List<int> numPares = numeros.FindAll(x => (x % 2) == 0 );

List<int> numPares = numeros.FindAll(x =>
{
    if (x % 2 == 0)
    {
        Console.WriteLine("Un Par");
        return true;
    }
    else
    {
        Console.WriteLine("Un Impar");
        return false;
    }
});

foreach( int num in numPares )
    Console.WriteLine(num);

numPares.ForEach(n => {  Console.WriteLine("El numero par es: " );
    Console.WriteLine(n);
});


/****************************************/

//OperacionesMatemticas operacion = new OperacionesMatemticas(Suma);
OperacionesMatemticas operacion = new OperacionesMatemticas((num1, num2) => num1 + num2); //Lambda

Console.WriteLine(operacion(4,7));

int Suma(int num1, int num2)
{
    return num1 + num2; 
}

delegate int OperacionesMatemticas(int numero1, int numero2);