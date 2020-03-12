using System;

namespace CondicionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {
              String linea;
            String mes;
            Console.Write("Ingrese las 3 primeras letras del mes");
            linea = Console.ReadLine();
            mes = lineas
           mes= mes.ToLower();
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
