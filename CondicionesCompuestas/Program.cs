using System;
 /**************************
  *Autor: Nicolás Fernández Heredia
  *Curso: 1DAW-M
  * Asignación: Condiciones Compuestas
  * Fecha de asignacion: 5 de febrero del 2020
  * ************************
  */

namespace CondicionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {

           
            //Variable que se usa para leer por teclado el mes
              String linea;
            String mes;
            Console.Write("Ingrese las 3 primeras letras del mes");
            Console.WriteLine("");
            linea = Console.ReadLine();
            mes = linea;
           mes= mes.ToLower();//Mediante el uso de varios if y los || hemos hecho que si el usuario escribe
            //las tres primeras letras de un mes te digan y te digan el mes
            if (mes == "oct" || mes == "nov" || mes == "dic"||mes == "ene" || mes == "feb" 
                || mes == "mar"||mes == "abr" || mes == "may" || mes == "jun")
            {
                if (mes == "oct" || mes == "nov" || mes == "dic"){
                    Console.WriteLine("Pertenece al primer trimestre");
                }else if(mes == "ene" || mes == "feb" || mes == "mar"){
                    Console.WriteLine("Pertenece al segundo trimestre");
                }else if (mes == "abr" || mes == "may" || mes == "jun")
                {
                    Console.WriteLine("Pertenece al tercer trimestre");
                }
            } else{ Console.WriteLine("Mes incorrecto"); }
        }
    }
}
