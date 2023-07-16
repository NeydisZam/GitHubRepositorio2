using System;

namespace JerarquiaEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            empleadoComision ec=new empleadoComision(2,"Pedro","Paramo",245.50f, 0.05f);
            empleadoHora eh=new empleadoHora(1,"Freddy","Palacios",24,175.80f);
            empleadoBaseComision ebc=new empleadoBaseComision(3,"Maria","Lopez",12541.5f,0.05f,2500);
            empleadoAsalariado ea=new empleadoAsalariado(4,"Juan","Cruz",1600);
            eh.calcularSalario();
            ec.calcularSalario();
            ebc.calcularSalario();
            ea.calcularSalario();
            Console.WriteLine($"Empleado Asalario {eh.MostrarInformacion():f,2}");
            Console.WriteLine($"Empleado Comision {ec.MostrarInformacion():f,2}");
            Console.WriteLine($"Empleado Base comision {ebc.MostrarInformacion()}");
            Console.WriteLine($"Empleado Asalariado {ea.MostrarInformacion()}");
            
        }
    }
}
