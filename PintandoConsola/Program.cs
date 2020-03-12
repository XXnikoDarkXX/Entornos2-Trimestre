using System;

namespace PintandoConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            Random a = new Random();
            Random ca = new Random();
            int hola = ca.Next(0, 2);
            Console.WriteLine("Hola es " + hola);
            char[] caracteres = new char[3];
            caracteres[0] = '&';
            caracteres[1] = '%';
            caracteres[2] = '#';
            int posX, posY;
            for (int i = 0; i < 3000; i++)
            {
                hola = ca.Next(0, 2);

                Console.Title = "Colores aleatorios";
                //  Console.BackgroundColor = ConsoleColor.Green;
                //   Console.ForegroundColor = ConsoleColor.Black;


                posY = a.Next(0, 24);  // En la fila 10

                posX = r.Next(0, 80); // Columna al azar entre 20 y 40
                Console.SetCursorPosition(posX, posY);
                //Pintamos  Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = (ConsoleColor)r.Next(16);
                Console.BackgroundColor = (ConsoleColor)ca.Next(16);
                Console.Write(caracteres[hola]);




            }
            Console.ReadKey(true);
        }
    }
    }

