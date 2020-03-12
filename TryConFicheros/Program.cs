using System;

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


                System.IO.StreamReader file =
                    new System.IO.StreamReader(@"C:/Users/nicoc/Documents/datos.txt");
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }
                Console.WriteLine("Dime un numero equivocate para que antes que se cierre el leer pueda usarse el catch");
                byte numero = Convert.ToByte(Console.ReadLine());
                file.Close();
                System.Console.WriteLine("There were {0} lines.", counter);
                // Suspend the screen.
            }
            catch (Exception e)
            {
                Console.WriteLine("Error exceptcional se cierra la lectura");
                Console.WriteLine(e.Message);
            }
            System.Console.ReadLine();
        }
    }
}
