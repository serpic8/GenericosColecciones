using PruebaGenericos;

AlmacenObjetos archivos = new AlmacenObjetos(4);
//archivos.Agregar("Luisa");
//archivos.Agregar("Elena");
//archivos.Agregar("Katherine");
//archivos.Agregar("Nelio");

archivos.Agregar(new Empleado(1500));
archivos.Agregar(new Empleado(2500));
archivos.Agregar(new Empleado(3500));
archivos.Agregar(new Empleado(4500));

Empleado nombrePersona = (Empleado)archivos.GetElemento(2);
Console.WriteLine(nombrePersona.Salario);

AlmacenObjetos2<Empleado> empleados = new AlmacenObjetos2<Empleado>(4);
empleados.Agregar(new Empleado(1500));
empleados.Agregar(new Empleado(2500));
empleados.Agregar(new Empleado(3500));
empleados.Agregar(new Empleado(4500));

Empleado salarioEmpleado = empleados.GetElemento(2);
Console.WriteLine(salarioEmpleado.Salario);