using System;
/**************************
 *Autor: Nicolás Fernández Heredia
 *Curso: 1DAW-M
 * Asignación: PintandoConsola
 * Fecha de asignacion: 4 de marzo del 2020
 * ************************
 */

namespace PintandoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usamos tres diferentes numeros random
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
            //En for lo que hare es asignar al azar en donde vamos pintar el pixel en un rango con el simbolo al azar.
            //se hara 3000 iteciones
            for (int i = 0; i < 3000; i++)
            {
                hola = ca.Next(0, 2);

                Console.Title = "Colores aleatorios";
                //  Console.BackgroundColor = ConsoleColor.Green;
                //   Console.ForegroundColor = ConsoleColor.Black;


                posY = a.Next(0, 24);  // En la fila 10

                posX = r.Next(0, 80); // Columna al azar entre 20 y 40
                Console.SetCursorPosition(posX, posY);//Cambiar aleatoriamente el cursor mediante un random en un rango
                //Pintamos  Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = (ConsoleColor)r.Next(16);//Cambiamos el color de las letras del cursor
                Console.BackgroundColor = (ConsoleColor)ca.Next(16);//Cambiamos el color del fondo donde esta el cursor
                Console.Write(caracteres[hola]);//Imprimmos un simbolo del array en el cursor aleatoriamente con los fondos




            }
            Console.SetCursorPosition(0, 25);//Posicionamos el cursor
            Console.ReadKey(true);
        }
    }
    }

