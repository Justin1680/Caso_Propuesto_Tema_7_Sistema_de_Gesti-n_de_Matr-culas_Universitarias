using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Matrículas_Universitarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Codigo del Estudiante");
            string codigo = Console.ReadLine();

            Console.WriteLine("Ingrese nombre completo del Estudiante");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresar la Carrera que estudias");
            string carrera = Console.ReadLine();

            Console.WriteLine("Ingrese su ciclo academico");
            int ciclo = Convert.ToInt32(Console.ReadLine());    

            Console.WriteLine("Ingrese su promedio ponderado del anterior ciclo");
            double promedio = double.Parse(Console.ReadLine());

            int CantidadCursos;

            do
            {
                Console.WriteLine("Cantidad de Cursos a Registrar (1-7)");
                CantidadCursos = int.Parse(Console.ReadLine());

                if (CantidadCursos < 1 || CantidadCursos > 7)
                {
                    Console.WriteLine("Error: Debe ingresar solo hasta 7 cursos");
                }
            }
            while (CantidadCursos < 1 || CantidadCursos > 7);
            string[] cursos = new string[CantidadCursos];
            int[] creditos = new int[CantidadCursos];

            int totalCreditos = 0;

            for (int i = 0; i < CantidadCursos; i++)
            {
                Console.WriteLine($"\nCurso {i + 1}");

                Console.WriteLine("Nombre del curso: ");
                cursos[i] = Console.ReadLine();

                Console.WriteLine("Cantidad de créditos: ");
                creditos[i] = Convert.ToInt32(Console.ReadLine());

                totalCreditos += creditos[i];

                Console.WriteLine($"\nTotal de créditos matriculados: {totalCreditos}");
            }

            if (totalCreditos < 12)
            {
                Console.WriteLine("Matricula de tiempo parcial");
            }
            else
            {
                if (totalCreditos <= 12 && totalCreditos >= 22)
                {
                    Console.WriteLine("Matricula Regular");
                }
                else
                {
                    Console.WriteLine("Error: No se puede registrar");
                }
            }
            double costoCredito = 85.00;
            double subtotal = totalCreditos * costoCredito;

            double porcentajeDescuento = 0;

            if (promedio >= 18 && promedio <= 20)
            {
                Console.WriteLine("Tiene un Descuento del 20%");
            }
            else
            {
                if (promedio >= 16 && promedio <= 17.99)
                {
                    Console.WriteLine("Tiene un Descuento del 10%");
                }
                else
                {
                    Console.WriteLine("No dispone de Ningun Descuento");
                }
            }


        }
    }
}
