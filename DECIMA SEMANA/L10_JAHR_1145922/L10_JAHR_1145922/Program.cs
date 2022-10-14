using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_JAHR_1145922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oportunidades = 0;
            int cantveces = 0;
            string username;
            string codigo;
            bool opcion = false;

            while (cantveces < 3)
            {
                Console.WriteLine("Ingrese usuario:");
                username = Console.ReadLine();
                Console.WriteLine("Ingrese constraseña:");
                codigo = Console.ReadLine();

                opcion = Login(username, codigo);
                if (opcion == true)
                {
                    cantveces = 3;
                    Console.WriteLine("Sesión iniciada");
                }else
                {
                    Console.WriteLine("No se ha iniciado sesión, cantidad de oportunidades: " + (oportunidades+1));
                    oportunidades++;
                    cantveces++;
                }
                if (oportunidades == 3)
                {
                    Console.WriteLine("Han acabado las oportunidades");
                }
            }
            Console.ReadKey();
        }
             static bool Login(string username, string codigo)
        {
            if(username == "usuario1" || codigo == "asdasd")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
