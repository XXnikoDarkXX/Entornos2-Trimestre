using System;
using System.Linq;
namespace Ejercicio1
  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos alumnos hay en clase?: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Los alumnos que hay son: " + cantidad);
            String nombre;
            float nota;
            String[] alumnos = new string[cantidad];
            float[] notasAlumnos = new float[cantidad];

            for (int i = 0; i < cantidad; i++)
            {

                Console.WriteLine("Introduce el nombre del alumno: ");
                nombre = Console.ReadLine();
                alumnos[i] = nombre;

                do
                {
                    Console.WriteLine("Introduce la nota del alumno: ");
                    nota = float.Parse(Console.ReadLine());

                } while (nota < 0 || nota > 10);
                notasAlumnos[i] = nota;

            }

            String mejorAlumno = "";
            float mejorNota = 0;

            for (int k = 0; k < cantidad; k++)
            {

                if (notasAlumnos[k] > mejorNota)
                {

                    mejorNota = notasAlumnos[k];
                    mejorAlumno = alumnos[k];

                }
            }

            Console.WriteLine("Este es el mejor alumno: " + mejorAlumno);
            Console.WriteLine("Esta es su nota: " + notasAlumnos.Max());
            Console.WriteLine("Esta es la media del curso: " + (notasAlumnos.Sum()) / cantidad);
        }
    }
}
