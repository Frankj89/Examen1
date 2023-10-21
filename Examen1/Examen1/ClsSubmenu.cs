using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClsSubmenu
    {
        

        static public void SubMenuReportes() 
        {

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine("--------SUB-MENU--------");
                Console.WriteLine(" ");
                Console.WriteLine("1- Consultar empleados");
                Console.WriteLine("2- Listar todos los empleados");
                Console.WriteLine("3- Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4- Calcular y mostrar el salario más alto y el más bajo de todos los empleados");
                Console.WriteLine("5- Salir");
                Console.WriteLine(" ");
                Console.WriteLine("Por favor digite una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: ClsEmpleado.Consultar();break;
                    case 2: ClsEmpleado.ListarEmpleado(); break;
                    case 3: ClsEmpleado.PromedioSalarios(); break;
                    case 4: ClsEmpleado.SalarioMinMax(); break;
                    
                    default:
                        break;
                }

            } while (opcion!=5);
        
        }
    
    }
}
