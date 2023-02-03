using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2yTarea
{
    class Program
    {
        static void Main(string[] args)
        {

            var persona = new { Nombre = "Miguel", Apellido = "Rios", Edad = 30 };
            string nombre = "Carolina";
            string Nombre = "Luis Carlos";
            string apellido = "Rodriguez";
            string Apellido = "Morera";


            Console.ForegroundColor = ConsoleColor.White;



            //arreglos-matrices
            int[] edad = new int[] { 20, 22, 33 };
            int[] salarios = new int[] { 200, 300, 150 };
            string[] musico = new string[3];
            musico[0] = "Ringo";
            musico[1] = "Paul";
            musico[2] = "John";

            Console.WriteLine(musico.Length);
            for (int i = 0; i < musico.Length; i++) 
            {
                Double IVA = 0;
                IVA = (salarios[i] * 0.13);
                Console.WriteLine($"{musico[i]} edad: {edad[i]} salario: {salarios[i]} IVA: {salarios[i] * 0.13} total: ");
                    }
        


            Console.WriteLine($"{persona.Nombre} {persona.Apellido} {persona.Edad}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dgite el salario por hora: ");
            double Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite las horas trabajadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"El empleado {0} {1}  recibe un salario de: {2} colones", nombre, Apellido, (horas * Salario));
        }
    }
}
