using System;
/**************************
 *Autor: Nicolás Fernández Heredia
 *Curso: 1DAW-M
 * Asignación: TryCatch con ficheros
 * Fecha de asignacion: 4 de marzo del 2020
 * ************************
 */

namespace TryConFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            try
            {

                //Leemos el fichero mediante una ruta absoluta
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@"C:/Users/nicoc/Documents/GitHub/Entornos2-Trimestre/TryConFicheros/datos.txt");
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }//nos equivamos en el numero para que se haga el try catch y el fichero se cierre sin que deje de compilar
                //el programa y cierre correctamente 
                Console.WriteLine("Dime un numero equivocate para que antes que se cierre el leer pueda usarse el catch");
                byte numero = Convert.ToByte(Console.ReadLine());
                file.Close();
                System.Console.WriteLine("There were {0} lines.", counter);
                // Suspend the screen.
            }
            catch (Exception e)//Catch por el cual hacemos que se cierre el texto 
            {
                Console.WriteLine("Error exceptcional se cierra la lectura");
                Console.WriteLine(e.Message);//El mensaje del error informatico
            }
            System.Console.ReadLine();
        }
    }
}
