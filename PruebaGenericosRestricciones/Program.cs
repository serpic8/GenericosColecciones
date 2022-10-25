using PruebaGenericosRestricciones;

AlmacenEmpleados<Director> empleado1 = 
    new AlmacenEmpleados<Director>(3);
empleado1.Agregar(new Director(4500));
empleado1.Agregar(new Director(1500));
empleado1.Agregar(new Director(2500));

AlmacenEmpleados<Secretario> empleado2 =
    new AlmacenEmpleados<Secretario>(3);
empleado2.Agregar(new Secretario(4500));
empleado2.Agregar(new Secretario(1500));
empleado2.Agregar(new Secretario(2500));

AlmacenEmpleados<Electricista> empleado3 =
    new AlmacenEmpleados<Electricista>(3);
empleado3.Agregar(new Electricista(4500));
empleado3.Agregar(new Electricista(1500));
empleado3.Agregar(new Electricista(2500));

AlmacenEmpleados<Estudiante> estudiante = 
    new AlmacenEmpleados<Estudiante>;
