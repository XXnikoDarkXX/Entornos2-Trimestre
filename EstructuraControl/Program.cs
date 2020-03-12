using System;

namespace EstructuraControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            string linea;
            Random aleatorio = new Random();


            
            int coca = 100;

            int numero = aleatorio.Next(coca);


           

          

            {

                numero = aleatorio.Next(coca);
                Console.WriteLine("El numero random es" + numero);
                Console.WriteLine();
                String pares = "";
                String impares = "";
                long multiplicacionPares = 1;
                long multiplicacionImpares = 1;
              
                for (int i = 1; i < numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        pares += Convert.ToString(i) + " - ";
                        multiplicacionPares =+ i * i;
                    }
                    else
                    {
                        impares += Convert.ToString(i) + "- ";
                        multiplicacionImpares = +i * i;
                    }


                }
                Console.WriteLine("Estos son los pares" + pares);

                Console.WriteLine();
                Console.WriteLine("Esta es la multiplicacion de sus productos " + multiplicacionPares);
                Console.WriteLine();
                Console.Write(" Cuantos fueron impares? " + impares);
                Console.WriteLine();
                Console.WriteLine("Esta es la multiplicacion de sus productos " + multiplicacionImpares);

            }

            Console.ReadKey();
        }
    }
}
