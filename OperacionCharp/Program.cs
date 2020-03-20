using System;
using System;
/**************************
 *Autor: Nicolás Fernández Heredia
 *Curso: 1DAW-M
 * Asignación: Operacion Matematicas con  Charp
 * Fecha de asignacion: 19 de febrero del 2020
 * ************************
 */

namespace OperacionCharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero1;
            String operador = "+";
            Boolean comprobacion;
            double numero2 = 0;
            //Usamos un do while para ingresasr dos numeros y su operador. En caso de que tenga algun error el programa sale 
            //por salida sin dar error de compilacion sino, que no se ejecuta. al final nos dice el fallo del error
            do
            {
                Console.WriteLine("Escribe un numero");


                if (double.TryParse(Console.ReadLine(), out numero1))
                {
                    comprobacion = true;
                    Console.WriteLine("Has escrito el " + numero1);
                }
                else
                {
                    comprobacion = false;
                    Console.WriteLine("No has escrito un numero");
                }
            } while (comprobacion != true);

            Console.WriteLine("Escribe el operador");
            operador = Console.ReadLine();
            //  double numero2 = 0;
            //Usamos un do while para ingresasr dos numeros y su operador. En caso de que tenga algun error el programa sale 
            //por salida sin dar error de compilacion sino, que no se ejecuta. al final nos dice el fallo del error eso se hace
            //mediante el tryparse y controlandolo con un booleano si es true esque esta bien si es false esta mal
            //
            do
            {




                Console.WriteLine("Escribe un segundo  numero");

                if (double.TryParse(Console.ReadLine(), out numero2))
                {
                    comprobacion = true;
                    Console.WriteLine("Has escrito el " + numero2);
                }
                else
                {
                    comprobacion = false;
                    Console.WriteLine("No has escrito un numero");
                }
            } while (comprobacion != true);

            double suma;
            suma = numero2 + numero1;
            double multiplicacion = numero1 * numero2;
            //Usamos un switch  para elegir el operando y calculamos el resultado de los numeros
            switch (operador)
            {
                case "+":
                    Console.WriteLine("La suma de  " + numero1 + " +" + numero2 + " es " + suma);
                    break;
                case "-":
                    double resta = numero1 - numero2;
                    Console.WriteLine("La resta de " + numero1 + " - " + numero2 + " es " + resta);
                    break;
                case "*":

                    Console.WriteLine("La multiplicacion de " + numero1 + " * " + numero2 + " es " + multiplicacion);

                    break;
                case "x":
                    Console.WriteLine("La multiplicacion de " + numero1 + " x " + numero2 + " es " + multiplicacion);

                    break;
                case "/":
                    double division = numero1 / numero2;
                    Console.WriteLine("La division de " + numero1 + " / " + numero2 + " es " + division);

                    break;
                case "%":
                    double resto = numero1 % numero2;
                    Console.WriteLine("El resto de " + numero1 + " % " + numero2 + " es " + resto);

                    break;


                default:
                    Console.WriteLine("Ya te has equivocado!!!");
                    break;
            }
        }
    }
}
      
