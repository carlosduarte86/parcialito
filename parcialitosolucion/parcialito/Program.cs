using System;

namespace parcialito
{
    class Program
    {
        static void Main(string[] args)
        {
            int legajo;
            string nombre;
            int nota1, nota2, nota3;
            int promedio;
            int mejorNota1;
            int mejorNota2;
            Console.Write("Ingrese legajo del Alumno: ");
            legajo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese primer nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la tercer nota: ");
            nota3 = Convert.ToInt32(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3)/3;
            mejorNota1 = Math.Max(nota1, nota2);
            mejorNota2 = Math.Max(mejorNota1, nota3);
            Console.WriteLine("El Alumno: " + nombre);
            Console.WriteLine("Legajo: " + legajo);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("La mejor nota es:" + mejorNota2);
            Console.ReadKey();

        }
    }
}
