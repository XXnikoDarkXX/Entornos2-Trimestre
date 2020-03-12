using System;
using System.Linq;
namespace Ejercicio1
  
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamaño;
            Console.WriteLine("Cuantos alumnos hay");
            tamaño = Convert.ToInt32(Console.ReadLine());
            
            String[] nombre = new string[tamaño];
            float[] notas = new float[tamaño];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Dime el nombre del alumno"+i);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Los nombres son: "+ nombre[i]);


            }
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Dime las notas del alumno "+i);
                notas = Convert.ToSingle();
            }
        }
    }
}
