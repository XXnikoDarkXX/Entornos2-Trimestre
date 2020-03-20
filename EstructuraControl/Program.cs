using System;
/**************************
 *Autor: Nicolás Fernández Heredia
 *Curso: 1DAW-M
 * Asignación: Estructura Control
 * Fecha de asignacion: 12 de febrero del 2020
 * ************************
 */

namespace EstructuraControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p;
            n = -1;//Le asignamo el -1 porque en el while se va a ejectuar siempre que la n sea <0
            p = 1;
            String pares = "";
            while (n<=0)
            {
                //Pedimos un numero por teclado mediante un while
                Console.WriteLine("Introduce un numero");
                n = Convert.ToInt32(Console.ReadLine());
                
                //Usamos un for para hallar los pares e impartes
              
            }


            for (int i = 0; i < n; i++)
            {
                //usamos la if con la iteacion de resto 0 dividido entre 2 para sacar los pares
                //multiplicamos el mismo resultado por cada par para sacar el factorial
                if (i % 2 == 0)
                {
                  
                    if (i>0)
                    {
                        pares += Convert.ToString(i) + " ";//Guardamos los numeros parse
                        p = p * i; //Multiplicacion de los facores de pares
                    }
                   
                }


            }
            Console.WriteLine("Los pares del numero " + n + " son " + pares);
            Console.WriteLine("Y el total del factorial de los pares es " + p);

            Console.ReadKey();
        }
    }
}
