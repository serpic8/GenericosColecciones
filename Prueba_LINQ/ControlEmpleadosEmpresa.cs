using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_LINQ
{
    internal class ControlEmpleadosEmpresa
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpleadosEmpresa()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Microsoft" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "Sony" });
            listaEmpresas.Add(new Empresa { Id = 4, Nombre = "Apple" });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Owen Espinoza", Cargo = "CEO", EmpresaId = 1, Salario = 15000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Diana Chavarría", Cargo = "CEO", EmpresaId = 2, Salario = 15000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Felix Ruiz", Cargo = "Administrador", EmpresaId = 3, Salario = 15000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Lizet Lopez", Cargo = "Secretaria", EmpresaId = 4, Salario = 15000 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "Juan Perez", Cargo = "Ingeniero", EmpresaId = 1, Salario = 15000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Diana Alvarado", Cargo = "Electricista", EmpresaId = 2, Salario = 15000 });
           
        }

        public void ObtenerCEO()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados
                                         where empleado.Cargo == "CEO"
                                         select empleado;

            foreach(Empleado empleado in ceos)
                Console.WriteLine(empleado);
        }

        public void ObtenerSalarioMenor15000()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados
                                         where empleado.Salario < 15000
                                         select empleado;

            foreach (Empleado empleado in empleados)
                Console.WriteLine(empleado);
        }

        /*public void ObtenerEmpleadosEmpresa(int Id)
        {
            var empleados = from empleado in listaEmpleados
                            join empresa in listaEmpresas
                            on empleado.EmpresaId equals empresa.Id
                            where empresa.Id == Id
                            select empleado;

            foreach (Empleado empleado in empleados)
                Console.WriteLine(empleado);
        }*/

        public void ObtenerEmpleadosEmpresa(string emp)
        {
            var empleados = from empleado in listaEmpleados
                            join empresa in listaEmpresas
                            on empleado.EmpresaId equals empresa.Id
                            where empresa.Nombre == emp
                            select empleado;

            foreach (Empleado empleado in empleados)
                Console.WriteLine(empleado);
        }

        //aqui tmb te quedaste  

    }
}
